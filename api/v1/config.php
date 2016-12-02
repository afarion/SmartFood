<?

function GetConfigArray() 
{
    return array(

        "itemtype" => array(
        
            "table" => "titemtype",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"        => array( "field" => "id",          "type" => "key",    "required" => true ),
                "name"      => array( "field" => "name",        "type" => "text",   "required" => true ),
                "visible"   => array( "field" => "visible",     "type" => "int",    "required" => true ),
            ),
            
            "fields" => array(
                "name"          => array( "type" => "text",   "default" => false,   "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
        
            "order" => array(
                "priority"  => "titemtype.priority desc, titemtype.id",
                "name"      => "titemtype.name",
                "create"    => "titemtype.id",
            ),
        ),
        
        "itemcategory" => array(
        
            "table" => "titemcategory",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"        => array( "field" => "id",      "type" => "key",    "required" => true ),
                "name"      => array( "field" => "name",    "type" => "text",   "required" => true ),
                "id_type"   => array( "field" => "id_type", "type" => "int",    "required" => true ),
                "visible"   => array( "field" => "visible", "type" => "int",    "required" => true ),
            ),
            
            "fields" => array(
                "name"          => array( "type" => "text",   "default" => false,   "editable" => true ),
                "id_type"       => array( "type" => "int",    "default" => false,   "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
            
            "filters" => array(
                "type"   => array( "field" => "id_type",  "type" => "int_equals" ),
            ),
        
            "order" => array(
                "priority"  => "titemcategory.priority desc, titemcategory.id",
                "name"      => "titemcategory.name",
                "create"    => "titemcategory.id",
            ),
        ),
        
        "unit" => array(
        
            "table" => "tunit",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   false,  false,  false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"    => array( "field" => "id",      "type" => "key",    "required" => true ),
                "name"  => array( "field" => "name",    "type" => "text",   "required" => true ),
                "abbr"  => array( "field" => "abbr",    "type" => "text",   "required" => true ),
            ),
            
            "show_only" => array(
                "visible > 0"
            ),
        
            "order" => array(
                "priority"  => "tunit.priority desc, tunit.id",
                "name"      => "tunit.name",
                "create"    => "tunit.id",
            ),
        ),
    
        "item" => array(
        
            "table" => "titem",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"            => array( "field" => "id",          "type" => "key",    "required" => true ),
                "name"          => array( "field" => "name",        "type" => "text",   "required" => true ),
                
                "id_type"       => array( "field" => "id_type",     "type" => "int",    "required" => true ),
                "id_category"   => array( "field" => "id_category", "type" => "int",    "required" => true ),
                "id_unit"       => array( "field" => "id_unit",     "type" => "int",    "required" => true ),
                
                "amount"        => array( "field" => "amount",      "type" => "float",  "required" => true ),
                "price"         => array( "field" => "price",       "type" => "price",  "required" => true ),
                "visible"       => array( "field" => "visible",     "type" => "int",    "required" => true ),
                
                "type"          => array( "field" => "id_type",     "type" => "table",  "required" => false, "join" => array("titemtype", "name", "id") ),
                "category"      => array( "field" => "id_category", "type" => "table",  "required" => false, "join" => array("titemcategory", "name", "id") ),
                "unit"          => array( "field" => "id_unit",     "type" => "table",  "required" => false, "join" => array("tunit", "abbr", "id") ),
            ),
            
            "fields" => array(
                "name"          => array( "type" => "text",   "default" => false,   "editable" => true ),
                "id_type"       => array( "type" => "int",    "default" => false,   "editable" => true ),
                "id_category"   => array( "type" => "int",    "default" => false,   "editable" => true ),
                "id_unit"       => array( "type" => "int",    "default" => false,   "editable" => true ),
                //"amount"        => array( "type" => "float",  "default" => 0,       "editable" => true ),
                "price"         => array( "type" => "float",  "default" => 0,       "editable" => false ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
            
            "filters" => array(
                "type"      => array( "field" => "id_type",     "type" => "int_equals" ),
                "category"  => array( "field" => "id_category", "type" => "int_equals" ),
            ),
        
            "order" => array(
                "priority"      => "titem.priority desc, titem.id",
                "name"          => "titem.name",
                "amount"        => "titem.amount",
                "price"         => "titem.price",
                "price_desc"    => "titem.price desc",
                "create"        => "titem.id",
            ),
        ),
        
        "provider" => array(
        
            "table" => "tprovider",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"        => array( "field" => "id",          "type" => "key",    "required" => true ),
                "name"      => array( "field" => "name",        "type" => "text",   "required" => true ),
                "notes"     => array( "field" => "notes",       "type" => "text",   "required" => true ),
                "visible"   => array( "field" => "visible",     "type" => "int",    "required" => true ),
            ),
            
            "fields" => array(
                "name"          => array( "type" => "text",   "default" => false,   "editable" => true ),
                "notes"         => array( "type" => "text",   "default" => "",      "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
        
            "order" => array(
                "priority"  => "tprovider.priority desc, tprovider.id",
                "name"      => "tprovider.name",
                "create"    => "tprovider.id",
            ),
        ),
        
        "employeetype" => array(
        
            "table" => "temployeetype",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   false,  false,  false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"    => array( "field" => "id",      "type" => "key",    "required" => true ),
                "name"  => array( "field" => "name",    "type" => "text",   "required" => true ),
            ),
            
            "show_only" => array(
                "visible > 0"
            ),
        
            "order" => array(
                "priority"  => "temployeetype.priority desc, temployeetype.id",
                "name"      => "temployeetype.name",
                "create"    => "temployeetype.id",
            ),
        ),
        
        "employee" => array(
        
            "table" => "temployee",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"            => array( "field" => "id",          "type" => "key",    "required" => true ),
                "id_type"       => array( "field" => "id_type",     "type" => "int",    "required" => true ),
                "first_name"    => array( "field" => "first_name",  "type" => "text",   "required" => true ),
                "last_name"     => array( "field" => "last_name",   "type" => "text",   "required" => true ),
                "phone"         => array( "field" => "phone",       "type" => "text",   "required" => true ),
                "phone_ex"      => array( "field" => "phone_ex",    "type" => "text",   "required" => true ),
                "skype"         => array( "field" => "skype",       "type" => "text",   "required" => true ),
                "address"       => array( "field" => "address",     "type" => "text",   "required" => true ),
                "email"         => array( "field" => "email",       "type" => "text",   "required" => true ),
                "birthday"      => array( "field" => "birthday",    "type" => "date",   "required" => true ),
                "comment"       => array( "field" => "comment",     "type" => "text",   "required" => true ),
                "visible"       => array( "field" => "visible",     "type" => "int",    "required" => true ),
            ),
            
            "fields" => array(
                "id_type"       => array( "type" => "int",    "default" => false,   "editable" => true ),
                "first_name"    => array( "type" => "text",   "default" => false,   "editable" => true ),
                "last_name"     => array( "type" => "text",   "default" => false,   "editable" => true ),
                "phone"         => array( "type" => "text",   "default" => "NULL",  "editable" => true ),
                "phone_ex"      => array( "type" => "text",   "default" => "NULL",  "editable" => true ),
                "skype"         => array( "type" => "text",   "default" => "NULL",  "editable" => true ),
                "address"       => array( "type" => "text",   "default" => "NULL",  "editable" => true ),
                "email"         => array( "type" => "text",   "default" => "NULL",  "editable" => true ),
                "birthday"      => array( "type" => "date",   "default" => "NULL",  "editable" => true ),
                "comment"       => array( "type" => "text",   "default" => "NULL",  "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
            
            "filters" => array(
                "type"   => array( "field" => "id_type",  "type" => "int_equals" ),
            ),
        
            "order" => array(
                "priority"  => "temployee.priority desc, temployee.id",
                "name"      => "temployee.name",
                "create"    => "temployee.id",
            ),
        ),

        "user" => array(
        
            "table" => "tuser",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"                => array( "field" => "id",              "type" => "key",    "required" => true ),
                "name"              => array( "field" => "name",            "type" => "text",   "required" => true ),
                "phone"             => array( "field" => "phone",           "type" => "text",   "required" => true ),
                "email"             => array( "field" => "email",           "type" => "text",   "required" => true ),
                "discount_fixed"    => array( "field" => "discount_fixed",  "type" => "int",    "required" => true ),
                "discount_stored"   => array( "field" => "discount_stored", "type" => "int",    "required" => true ),
                "total_balance"     => array( "field" => "total_balance",   "type" => "price",  "required" => true ),
                "comment"           => array( "field" => "comment",         "type" => "text",   "required" => true ),
                "visible"           => array( "field" => "visible",         "type" => "int",    "required" => true ),
            ),
            
            "fields" => array(
                "name"              => array( "type" => "text",     "default" => false,   "editable" => true ),
                "phone"             => array( "type" => "text",     "default" => "NULL",  "editable" => true ),
                "email"             => array( "type" => "text",     "default" => "NULL",  "editable" => true ),
                "discount_fixed"    => array( "type" => "int",      "default" => "NULL",  "editable" => true ),
                "discount_stored"   => array( "type" => "int",      "default" => "NULL",  "editable" => false ),
                "total_balance"     => array( "type" => "float",    "default" => "NULL",  "editable" => false ),
                "comment"           => array( "type" => "text",     "default" => "NULL",  "editable" => true ),
                "visible"           => array( "type" => "flag",     "default" => 1,       "editable" => true ),
            ),
            
            "order" => array(
                "create"    => "tuser.id",
                "name"      => "tuser.name",
            ),
        ),  
        
        "useraddress" => array(
        
            "table" => "tuseraddress",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"        => array( "field" => "id",      "type" => "key",    "required" => true ),
                "address"   => array( "field" => "address", "type" => "text",   "required" => true ),
                "id_user"   => array( "field" => "id_user", "type" => "int",    "required" => true ),
                "visible"   => array( "field" => "visible", "type" => "int",    "required" => true ),
            ),
            
            "fields" => array(
                "address"       => array( "type" => "text",   "default" => false,   "editable" => true ),
                "id_user"       => array( "type" => "int",    "default" => false,   "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
            
            "filters" => array(
                "user"   => array( "field" => "id_user",  "type" => "int_equals" ),
            ),
        
            "order" => array(
                "priority"  => "tuseraddress.priority desc, tuseraddress.id",
                "create"    => "titemcategory.id",
            ),
        ),
        
        "admin" => array(
        
            "table" => "tadmin",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"            => array( "field" => "id",          "type" => "key",    "required" => true ),
                "id_type"       => array( "field" => "id_type",     "type" => "int",    "required" => true ),
                "id_employee"   => array( "field" => "id_employee", "type" => "int",    "required" => true ),
                "login"         => array( "field" => "login",       "type" => "text",   "required" => true ),
                "visible"       => array( "field" => "visible",     "type" => "int",    "required" => true ),
            ),
            
            "fields" => array(
                "id_type"       => array( "type" => "int",    "default" => false,   "editable" => true ),
                "id_employee"   => array( "type" => "int",    "default" => false,   "editable" => true ),
                "login"         => array( "type" => "text",   "default" => false,   "editable" => true ),
                "pass"          => array( "type" => "pass",   "default" => false,   "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
            
            "filters" => array(
                "type"      => array( "field" => "id_type",     "type" => "int_equals" ),
                "employee"  => array( "field" => "id_employee", "type" => "int_equals" ),
            ),
        
            "order" => array(
                "create"    => "tadmin.id",
                "name"      => "tadmin.name",
            ),
        ),
          
    /*

        "hotel" => array(
        
            "table" => "thotel",
        
            "part" => array(
                "id"        => array( "field" => "id",          "type" => "key",    "required" => true ),
                "name"      => array( "field" => "name",        "type" => "text",   "required" => true ),
                "rating"    => array( "field" => "rating",      "type" => "int",    "required" => false ),
                "email"     => array( "field" => "email",       "type" => "text",   "required" => false ),
                "gps"       => array( "field" => "gps",         "type" => "text",   "required" => false ),
                "phone"     => array( "field" => "phone",       "type" => "text",   "required" => false ),
                "address"   => array( "field" => "address",     "type" => "text",   "required" => false ),
                "image"     => array( "field" => "img",         "type" => "image",  "required" => false ),
                "poc"       => array( "field" => "poc",         "type" => "text",   "required" => false ),
                "short"     => array( "field" => "short_des",   "type" => "text",   "required" => false ),
                "full"      => array( "field" => "full_des",    "type" => "text",   "required" => false ),
                "notes"     => array( "field" => "notes",       "type" => "text",   "required" => false ),
            ),
            
            "relations" => array(
                "deals" => array("method" => "deal", "key" => "id_hotel"),
            ),
            
            "show_only" => array(
                "visible > 0"
            ),
            
            "filters" => array(
                "id"        => array( "field" => "id",          "type" => "in_array" ),
                "q"         => array( "field" => "name",        "type" => "text_contains" ),
                "city"      => array( "field" => "id_city",     "type" => "int_equals" ),
                "roomtype"  => array( "field" => "id_roomtype", "type" => "in_array",   "related" => array("troomdeal", "id_hotel", "id", " AND visible > 0 AND date_finish > NOW() ") ),
            ),
            
            "order" => array(
                "name"      => "thotel.name",
                "create"    => "thotel.date_insert",
                
                "rating"    => "thotel.rating desc",
                
                "price"     => array( 
                    "table" => "troomdeal",
                    "by" => "troomdeal.tonight_price, thotel.rating", 
                    "join" => " LEFT JOIN troomdeal ON troomdeal.id_hotel = thotel.id ",
                    "where" => " AND troomdeal.visible > 0 AND troomdeal.date_finish > NOW() ",
                    "distinct" => true,
                    ),
                    
                "date"      => array( 
                    "table" => "troomdeal",
                    "by" => "troomdeal.date_finish, thotel.rating", 
                    "join" => " LEFT JOIN troomdeal ON troomdeal.id_hotel = thotel.id ",
                    "where" => " AND troomdeal.visible > 0 AND troomdeal.date_finish > NOW() ",
                    "distinct" => true,
                    ),
            ),
        
        ),
        
        
        
        "order" => array(
        
            "table" => "torder",
            
            "auth" => array(
                "user_id"       => array( "type" => "int",    "required" => true ),
                "hash"          => array( "type" => "text",   "required" => true ),
            ),
        
            "part" => array(
                "id"            => array( "field" => "id",              "type" => "key",    "required" => true ),
                
                //"hotel_id"      => array( "field" => "id_hotel",        "type" => "int",    "required" => false ),
                //"deal_id"       => array( "field" => "id_roomdeal",     "type" => "int",    "required" => false ),
                //"user_id"       => array( "field" => "id_user",         "type" => "int",    "required" => false ),
                //"manager_id"    => array( "field" => "id_manager",      "type" => "int",    "required" => false ),
                //"status_id"     => array( "field" => "id_status",       "type" => "int",    "required" => false ),
                //"duration_id"   => array( "field" => "id_duration",     "type" => "int",    "required" => false ),
                
                "hotel_name"    => array( "field" => "id_hotel",        "type" => "table",  "required" => false, "join" => array("thotel", "name", "id") ),
                "hotel_phone"   => array( "field" => "id_hotel",        "type" => "table",  "required" => false, "join" => array("thotel", "phone", "id") ),
                "hotel_address" => array( "field" => "id_hotel",        "type" => "table",  "required" => false, "join" => array("thotel", "address", "id") ),
                
                "duration"      => array( "field" => "id_duration",     "type" => "table",  "required" => false, "join" => array("tduration", "name", "id") ),
                "checkout"      => array( "field" => "id_checkout",     "type" => "table",  "required" => false, "join" => array("tcheckout", "name", "id") ),
                "status"        => array( "field" => "id_status",       "type" => "table",  "required" => false, "join" => array("torderstatus", "name", "id") ),
                
                "user_name"     => array( "field" => "user_name",       "type" => "text",   "required" => false ),
                "manager_name"  => array( "field" => "manager_name",    "type" => "text",   "required" => false ),
                "room_name"     => array( "field" => "room_name",       "type" => "text",   "required" => false ),
                "user_phone"    => array( "field" => "user_phone",      "type" => "text",   "required" => false ),
                "user_email"    => array( "field" => "user_email",      "type" => "text",   "required" => false ),
                
                //"price"         => array( "field" => "price",           "type" => "price",  "required" => false ),
                //"tonight_price" => array( "field" => "tonight_price",   "type" => "price",  "required" => false ),
                "tax"               => array( "field" => "tax",             "type" => "int",  "required" => false ),
                
                "tax_price"         => array( "field" => "tax_price",       "type" => "price",  "required" => false ),
                "subtotal_price"    => array( "field" => "subtotal_price",  "type" => "price",  "required" => false ),
                
                "total_price"       => array( "field" => "total_price",     "type" => "price",  "required" => false ),
                
                //"notes"         => array( "field" => "notes",           "type" => "text",   "required" => false ),
                //"notes_user"    => array( "field" => "notes_user",      "type" => "text",   "required" => false ),
                
                "submit_date"   => array( "field" => "date_insert",     "type" => "text",   "required" => false ),
            ),
            
            "show_only" => array(
                "visible > 0"
            ),
            
            "relations" => array(
                "services" => array("method" => "orderservice", "key" => "id_order"),
            ),
            
            "filters" => array(
                "user_id"    => array( "field" => "id_user",      "type" => "int_equals" ),
            ),
            
            "order" => array(
                "create"    => "torder.date_insert",
                "date"      => "torder.date_insert desc",
            ),       
        ),
        
        "orderservice" => array(
        
            "table" => "torderservice",
        
            "part" => array(
                "id"            => array( "field" => "id",              "type" => "key",    "required" => true ),
                "name"          => array( "field" => "id_service",      "type" => "table",  "required" => true, "join" => array("tservice", "name", "id") ),
                "price"         => array( "field" => "price",           "type" => "price",  "required" => false ),
                "tonight_price" => array( "field" => "tonight_price",   "type" => "price",  "required" => false ),
                "description"   => array( "field" => "description",     "type" => "text",   "required" => false ),
            ),
            
            "show_only" => array(
                "visible > 0"
            ),       
        ),
        */
        
        "errors" => array(
            "request"   => array( "code" => 1,      "status_code" => 400,   "message" => "Wrong request" ),
            "method"    => array( "code" => 2,      "status_code" => 400,   "message" => "Wrong request method" ),
            
            "count"     => array( "code" => 10,     "status_code" => 400,   "message" => "Wrong 'count' value" ),
            "offset"    => array( "code" => 11,     "status_code" => 400,   "message" => "Wrong 'offset' value" ),
            "page"      => array( "code" => 12,     "status_code" => 400,   "message" => "Wrong 'page' value" ),
            
            "resp"      => array( "code" => 20,     "status_code" => 400,   "message" => "Invalid response" ),
            "action"    => array( "code" => 21,     "status_code" => 400,   "message" => "Invalid action" ),
            "user"      => array( "code" => 22,     "status_code" => 400,   "message" => "Invalid user data" ),
            
            "insert"    => array( "code" => 31,     "status_code" => 400,   "message" => "Insert object error" ),
            
            "sid"       => array( "code" => 50,     "status_code" => 401,   "message" => "Wrong user sid" ),
            "perm"      => array( "code" => 51,     "status_code" => 403,   "message" => "You do not have permission for this action" ),
            
            "undefined" => array( "code" => 100,    "status_code" => 404,   "message" => "Undefined error" ),
            "not_found" => array( "code" => 101,    "status_code" => 404,   "message" => "Item not found" ),
        ),
        
    );

}

function GetAuthConfigArray() 
{
    return array(

        "table" => "tadmin",
        
        "login" => array(
                
            "params" => array(
                "type"      => array( "field" => "id_type",     "type" => "int" ),
                "login"     => array( "field" => "login",       "type" => "login" ),
                "pass"      => array( "field" => "pass",        "type" => "pass" ),
            ),
            
        ),
        
        "response_user_fields" => array(
            "id"        => array( "field" => "id" ),
            "type"      => array( "field" => "id_type" ),
            "login"     => array( "field" => "login" ),
            "sid"       => array( "field" => "sid" ),
        ),
        
        "errors" => array(
            "required"  => array( "code" => 1,  "status_code" => 400,   "message" => "All required fields must be filled" ),
            //"unique"    => array( "code" => 2,  "status_code" => 400,   "message" => "This user is already exist" ),
            //"create"    => array( "code" => 3,  "status_code" => 400,   "message" => "Create user error" ),
            "login"     => array( "code" => 4,  "status_code" => 400,   "message" => "Log in user error" ), 
            //"hash"      => array( "code" => 5,  "status_code" => 400,   "message" => "Invalid sid" ), 
            
            //"name"      => array( "code" => 10, "status_code" => 400,   "message" => "Wrong name" ),
            //"email"     => array( "code" => 11, "status_code" => 400,   "message" => "Wrong email" ),
            //"phone"     => array( "code" => 12, "status_code" => 400,   "message" => "Wrong phone" ),
            
            "undefined" => array( "code" => 100, "status_code" => 400,  "message" => "Undefined error" ),
        ),
        
        "settings" => array(
        
            "regulars" => array(
                "email" => "|([a-z0-9_\.\-]{1,20})@([a-z0-9\.\-]{1,20})\.([a-z]{2,4})|is",
                "phone" => "/^([0-9 \.\-\(\)])+$/iu",
                "login" => "/^[a-zA-Z]([0-9a-zA-Z_])+$/i",
            ),
            
        ),
        
    );

}

?>