<?

function GetConfigArray() 
{
    return array(

        "itemtype" => array(
        
            "table" => "titemtype",
            
            "log_table" => "titemtype_log",
            
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
        
            "sort" => array(
                "priority"  => "titemtype.priority desc, titemtype.id",
                "name"      => "titemtype.name",
                "create"    => "titemtype.id",
            ),
        ),
        
        "itemcategory" => array(
        
            "table" => "titemcategory",
            
            "log_table" => "titemcategory_log",
            
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
        
            "sort" => array(
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
        
            "sort" => array(
                "priority"  => "tunit.priority desc, tunit.id",
                "name"      => "tunit.name",
                "create"    => "tunit.id",
            ),
        ),
    
        "item" => array(
        
            "table" => "titem",
            
            "log_table" => "titem_log",
            
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
                "waste_pct"     => array( "field" => "waste_pct",   "type" => "int",    "required" => true ),
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
                "amount"        => array( "type" => "float",  "default" => 0,       "editable" => false ),
                "price"         => array( "type" => "float",  "default" => 0,       "editable" => false ),
                "waste_pct"     => array( "type" => "int",    "default" => 0,       "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
            
            "filters" => array(
                "type"      => array( "field" => "id_type",     "type" => "int_equals" ),
                "category"  => array( "field" => "id_category", "type" => "int_equals" ),
            ),
        
            "sort" => array(
                "priority"      => "titem.priority desc, titem.id",
                "name"          => "titem.name",
                "amount"        => "titem.amount",
                "price"         => "titem.price",
                "price_desc"    => "titem.price desc",
                "create"        => "titem.id",
            ),
        ),
        
        /*
        "prepack" => array(
        
            "table" => "tprepack",
            
            "log_table" => "tprepack_log",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"            => array( "field" => "id",          "type" => "key",    "required" => true ),
                "name"          => array( "field" => "name",        "type" => "text",   "required" => true ),
                "visible"       => array( "field" => "visible",     "type" => "int",    "required" => true ),
            ),
            
            "fields" => array(
                "name"          => array( "type" => "text",   "default" => false,   "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
        
            "sort" => array(
                "priority"      => "tprepack.priority desc, tprepack.id",
                "name"          => "tprepack.name",
                "create"        => "tprepack.id",
            ),
        ),
        
        "prepackitem" => array(
        
            "table" => "tprepackitem",
            
            "log_table" => "tprepackitem_log",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"            => array( "field" => "id",          "type" => "key",    "required" => true ),
                "id_prepack"    => array( "field" => "id_prepack",  "type" => "int",    "required" => true ),
                "id_item"       => array( "field" => "id_item",     "type" => "int",    "required" => true ),
                "waste_pct"     => array( "field" => "waste_pct",   "type" => "int",    "required" => true ),
                "visible"       => array( "field" => "visible",     "type" => "int",    "required" => true ),
            ),
            
            "fields" => array(
                "id_prepack"    => array( "type" => "int",    "default" => false,   "editable" => true ),
                "id_item"       => array( "type" => "int",    "default" => false,   "editable" => true ),
                "waste_pct"     => array( "type" => "int",    "default" => 0,       "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
            
            "filters" => array(
                "prepack"   => array( "field" => "id_prepack",  "type" => "int_equals" ),
                "item"      => array( "field" => "id_item",     "type" => "int_equals" ),
            ),
        
            "sort" => array(
                "priority"      => "tprepackitem.priority desc, tprepackitem.id",
                "name"          => "tprepackitem.name",
                "create"        => "tprepackitem.id",
            ),
        ),
        */
        
        "provider" => array(
        
            "table" => "tprovider",
            
            "log_table" => "tprovider_log",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"        => array( "field" => "id",          "type" => "key",    "required" => true ),
                "name"      => array( "field" => "name",        "type" => "text",   "required" => true ),
                "phone"     => array( "field" => "phone",       "type" => "text",   "required" => true ),
                "email"     => array( "field" => "email",       "type" => "text",   "required" => true ),
                "skype"     => array( "field" => "skype",       "type" => "text",   "required" => true ),
                "notes"     => array( "field" => "notes",       "type" => "text",   "required" => true ),
                "visible"   => array( "field" => "visible",     "type" => "int",    "required" => true ),
            ),
            
            "fields" => array(
                "name"          => array( "type" => "text",   "default" => false,   "editable" => true ),
                "phone"         => array( "type" => "text",   "default" => "",      "editable" => true ),
                "email"         => array( "type" => "text",   "default" => "",      "editable" => true ),
                "skype"         => array( "type" => "text",   "default" => "",      "editable" => true ),
                "notes"         => array( "type" => "text",   "default" => "",      "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
        
            "sort" => array(
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
        
            "sort" => array(
                "priority"  => "temployeetype.priority desc, temployeetype.id",
                "name"      => "temployeetype.name",
                "create"    => "temployeetype.id",
            ),
        ),
        
        "employee" => array(
        
            "table" => "temployee",
            
            "log_table" => "temployee_log",
            
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
                "phone"         => array( "type" => "text",   "default" => "",      "editable" => true ),
                "phone_ex"      => array( "type" => "text",   "default" => "",      "editable" => true ),
                "skype"         => array( "type" => "text",   "default" => "",      "editable" => true ),
                "address"       => array( "type" => "text",   "default" => "",      "editable" => true ),
                "email"         => array( "type" => "text",   "default" => "",      "editable" => true ),
                "birthday"      => array( "type" => "date",   "default" => "NULL",  "editable" => true ),
                "comment"       => array( "type" => "text",   "default" => "",      "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
            
            "filters" => array(
                "type"   => array( "field" => "id_type",  "type" => "int_equals" ),
            ),
        
            "sort" => array(
                "priority"  => "temployee.priority desc, temployee.id",
                "name"      => "temployee.name",
                "create"    => "temployee.id",
            ),
        ),

        "user" => array(
        
            "table" => "tuser",
            
            "log_table" => "tuser_log",
            
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
                "discount_reason"   => array( "field" => "discount_reason", "type" => "text",   "required" => true ),
                "visible"           => array( "field" => "visible",         "type" => "int",    "required" => true ),
            ),
            
            "fields" => array(
                "name"              => array( "type" => "text",     "default" => false,     "editable" => true ),
                "phone"             => array( "type" => "text",     "default" => false,     "editable" => true ),
                "email"             => array( "type" => "text",     "default" => "",        "editable" => true ),
                "discount_fixed"    => array( "type" => "int",      "default" => 0,         "editable" => true ),
                "discount_stored"   => array( "type" => "int",      "default" => 0,         "editable" => false ),
                "total_balance"     => array( "type" => "float",    "default" => 0,         "editable" => false ),
                "comment"           => array( "type" => "text",     "default" => "",        "editable" => true ),
                "discount_reason"   => array( "type" => "text",     "default" => "",        "editable" => true ),
                "visible"           => array( "type" => "flag",     "default" => 1,         "editable" => true ),
            ),
            
            "sort" => array(
                "create"    => "tuser.id",
                "name"      => "tuser.name",
            ),
        ),  
        
        "useraddress" => array(
        
            "table" => "tuseraddress",
            
            //"log_table" => "tuseraddress_log",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   false,  true,   true),   //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"        => array( "field" => "id",      "type" => "key",    "required" => true ),
                "address"   => array( "field" => "address", "type" => "text",   "required" => true ),
                //"id_user"   => array( "field" => "id_user", "type" => "int",    "required" => true ),
                //"visible"   => array( "field" => "visible", "type" => "int",    "required" => true ),
            ),
            
            "fields" => array(
                "address"       => array( "type" => "text",   "default" => false,   "editable" => true ),
                "id_user"       => array( "type" => "int",    "default" => false,   "editable" => true ),
                //"visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
            
            "filters" => array(
                "user"   => array( "field" => "id_user",  "type" => "int_equals",  "required" => true  ),
            ),
        
            "sort" => array(
                "priority"  => "tuseraddress.priority desc, tuseraddress.id",
                "create"    => "titemcategory.id",
            ),
        ),
        
        "admin" => array(
        
            "table" => "tadmin",
            
            "log_table" => "tadmin_log",
            
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
        
            "sort" => array(
                "create"    => "tadmin.id",
                "name"      => "tadmin.name",
            ),
        ),
        
        "purchase" => array(
        
            "table" => "tpurchase",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   false,  true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
            
            "part" => array(
                "id"            => array( "field" => "id",          "type" => "key",        "required" => true ),
                "id_item"       => array( "field" => "id_item",     "type" => "int",        "required" => true ),
                "id_provider"   => array( "field" => "id_provider", "type" => "int",        "required" => true ),
                "id_admin"      => array( "field" => "id_admin",    "type" => "int",        "required" => true ),
                "id_employee"   => array( "field" => "id_employee", "type" => "int",        "required" => true ),
                "amount"        => array( "field" => "amount",      "type" => "float",      "required" => true ),
                "price"         => array( "field" => "price",       "type" => "price",      "required" => true ),
                "date_create"   => array( "field" => "date_create", "type" => "datetime",   "required" => true ),
                
            ),
            
            "fields" => array(
                "id_item"       => array( "type" => "int",    "default" => false,   "editable" => false ),
                "id_provider"   => array( "type" => "int",    "default" => false,   "editable" => false ),
                "id_admin"      => array( "type" => "int",    "default" => false,   "editable" => false ),
                "id_employee"   => array( "type" => "int",    "default" => false,   "editable" => false ),
                "amount"        => array( "type" => "float",  "default" => false,   "editable" => false ),
                "price"         => array( "type" => "float",  "default" => false,   "editable" => false ),
            ),
            
            "filters" => array(
                "type"      => array( "field" => "id_type",     "type" => "int_equals" ),
                "provider"  => array( "field" => "id_provider", "type" => "int_equals" ),
                "admin"     => array( "field" => "id_admin",    "type" => "int_equals" ),
                "employee"  => array( "field" => "id_employee", "type" => "int_equals" ),
            ),
        
            "sort" => array(
                "create"    => "tpurchase.id",
            ),
            
            "add_callback" => "update_purchase",
        
        ),
        
        "outlay" => array(
        
            "table" => "toutlay",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   false,  true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
            
            "part" => array(
                "id"            => array( "field" => "id",          "type" => "key",        "required" => true ),
                "id_item"       => array( "field" => "id_item",     "type" => "int",        "required" => true ),
                "id_admin"      => array( "field" => "id_admin",    "type" => "int",        "required" => true ),
                "id_employee"   => array( "field" => "id_employee", "type" => "int",        "required" => true ),
                "amount"        => array( "field" => "amount",      "type" => "float",      "required" => true ),
                "waste"         => array( "field" => "waste",       "type" => "float",      "required" => true ),
                "comment"       => array( "field" => "comment",     "type" => "text",       "required" => true ),
                "date_create"   => array( "field" => "date_create", "type" => "datetime",   "required" => true ),
            ),
            
            "fields" => array(
                "id_item"       => array( "type" => "int",    "default" => false,   "editable" => false ),
                "id_admin"      => array( "type" => "int",    "default" => false,   "editable" => false ),
                "id_employee"   => array( "type" => "int",    "default" => false,   "editable" => false ),
                "amount"        => array( "type" => "float",  "default" => false,   "editable" => false ),
                "waste"         => array( "type" => "float",  "default" => 0,       "editable" => false ),
                "comment"       => array( "type" => "text",   "default" => false,   "editable" => false ),
            ),
            
            "filters" => array(
                "admin"     => array( "field" => "id_admin",    "type" => "int_equals" ),
                "employee"  => array( "field" => "id_employee", "type" => "int_equals" ),
            ),
        
            "sort" => array(
                "create"    => "toutlay.id",
            ),
            
            "add_callback" => "update_outlay",
        
        ),
        
        "dishcategory" => array(
        
            "table" => "tdishcategory",
            
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
        
            "sort" => array(
                "priority"  => "tdishcategory.priority desc, tdishcategory.id",
                "name"      => "tdishcategory.name",
                "create"    => "tdishcategory.id",
            ),
        ),
        
        "dish" => array(
        
            "table" => "tdish",
            
            "log_table" => "tdish_log",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"            => array( "field" => "id",          "type" => "key",    "required" => true ),
                "id_category"   => array( "field" => "id_category", "type" => "int",    "required" => true ),
                "name"          => array( "field" => "name",        "type" => "text",   "required" => true ),
                "weight"        => array( "field" => "weight",      "type" => "float",  "required" => true ),
                "price"         => array( "field" => "price",       "type" => "price",  "required" => true ),
                "visible"       => array( "field" => "visible",     "type" => "int",    "required" => true ),
                "category"      => array( "field" => "id_category", "type" => "table",  "required" => false, "join" => array("tdishcategory", "name", "id") ),
            ),
            
            "fields" => array(
                "id_category"   => array( "type" => "int",    "default" => false,   "editable" => true ),
                "name"          => array( "type" => "text",   "default" => false,   "editable" => true ),
                "weight"        => array( "type" => "float",  "default" => 0,       "editable" => true ),
                "price"         => array( "type" => "float",  "default" => 0,       "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
            
            "filters" => array(
                "category"  => array( "field" => "id_category", "type" => "int_equals" ),
            ),
        
            "sort" => array(
                "priority"      => "tdish.priority desc, tdish.id",
                "name"          => "tdish.name",
                "price"         => "tdish.price",
                "price_desc"    => "tdish.price desc",
                "create"        => "tdish.id",
            ),
        ),
        
        "dishitem" => array(
        
            "table" => "tdishitem",
            
            "log_table" => "tdishitem_log",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   true),   //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"            => array( "field" => "id",          "type" => "key",    "required" => true ),
                "id_dish"       => array( "field" => "id_dish",     "type" => "int",    "required" => true ),
                "id_item"       => array( "field" => "id_item",     "type" => "int",    "required" => true ),
                "weight"        => array( "field" => "weight",      "type" => "float",  "required" => true ),
                "visible"       => array( "field" => "visible",     "type" => "int",    "required" => true ),
                "item"          => array( "field" => "id_item",     "type" => "table",  "required" => false, "join" => array("titem", "name", "id") ),
            ),
            
            "fields" => array(
                "id_dish"       => array( "type" => "int",    "default" => false,   "editable" => true ),
                "id_item"       => array( "type" => "int",    "default" => false,   "editable" => true ),
                "weight"        => array( "type" => "float",  "default" => false,   "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
            
            "filters" => array(
                "dish"  => array( "field" => "id_dish", "type" => "int_equals",  "required" => true ),
            ),
        
            "sort" => array(
                "priority"      => "tdishitem.priority desc, tdishitem.id",
                "name"          => "tdishitem.name",
                "create"        => "tdishitem.id",
            ),
        ),
        
        "orderstatus" => array(
        
            "table" => "torderstatus",
            
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
        
            "sort" => array(
                "priority"  => "torderstatus.priority desc, torderstatus.id",
                "name"      => "torderstatus.name",
                "create"    => "torderstatus.id",
            ),
        ),
        
        "order" => array(
        
            "table" => "torder",
            
            "log_table" => "torder_log",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   false),  //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"                => array( "field" => "id",              "type" => "key",        "required" => true ),
                "id_user"           => array( "field" => "id_user",         "type" => "int",        "required" => true ),
                "id_admin"          => array( "field" => "id_admin",        "type" => "int",        "required" => true ),
                "id_courier"        => array( "field" => "id_courier",      "type" => "int",        "required" => true ),
                "id_status"         => array( "field" => "id_status",       "type" => "int",        "required" => true ),
                //"id_payform"        => array( "field" => "id_payform",      "type" => "int",        "required" => true ),
                "price"             => array( "field" => "price",           "type" => "price",      "required" => true ),
                "discount"          => array( "field" => "discount",        "type" => "int",        "required" => true ),
                "result_price"      => array( "field" => "result_price",    "type" => "price",      "required" => true ),
                "pickup"            => array( "field" => "pickup",          "type" => "int",        "required" => true ),
                "deliver_on_time"   => array( "field" => "deliver_on_time", "type" => "datetime",   "required" => true ),
                "address"           => array( "field" => "address",         "type" => "text",       "required" => true ),
                "date_create"       => array( "field" => "date_create",     "type" => "datetime",   "required" => true ),
                "date_compleate"    => array( "field" => "date_compleate",  "type" => "datetime",   "required" => true ),
                "date_pay"          => array( "field" => "date_pay",        "type" => "datetime",   "required" => true ),
                "visible"           => array( "field" => "visible",         "type" => "int",        "required" => true ),
            ),
            
            "fields" => array(
                "id_user"           => array( "type" => "int",      "default" => false,     "editable" => false ),
                "id_admin"          => array( "type" => "int",      "default" => false,     "editable" => true ),
                "id_courier"        => array( "type" => "int",      "default" => 0,         "editable" => true ),
                "id_status"         => array( "type" => "int",      "default" => 1,         "editable" => true ),
                //"id_payform"        => array( "type" => "int",      "default" => false,   "editable" => true ),
                "pickup"            => array( "type" => "flag",     "default" => 1,         "editable" => true ),
                "deliver_on_time"   => array( "type" => "datetime", "default" => "NULL",    "editable" => true ),
                "address"           => array( "type" => "text",     "default" => "",        "editable" => true ),
                "visible"           => array( "type" => "flag",     "default" => 1,         "editable" => true ),
            ),
            
            "filters" => array(
                "user"      => array( "field" => "id_user",     "type" => "int_equals" ),
                "admin"     => array( "field" => "id_admin",    "type" => "int_equals" ),
                "courier"   => array( "field" => "id_courier",  "type" => "int_equals" ),
            ),
        
            "sort" => array(
                "create"        => "torder.date_create desc",
                "compleate"     => "torder.date_compleate desc",
            ),
            
            "add_callback" => "add_order",
            
            "edit_callback" => "edit_order",
        ),
        
        "orderdish" => array(
        
            "table" => "torderdish",
            
            "log_table" => "torderdish_log",
            
            "permission" => array( 
                //          view    edit    add     remove
                1 => array( true,   true,   true,   true),   //Администратор
                2 => array( true,   false,  false,  false),  //Оператор
                3 => array( true,   false,  false,  false),  //Повар
            ),
        
            "part" => array(
                "id"            => array( "field" => "id",          "type" => "key",    "required" => true ),
                "id_order"      => array( "field" => "id_order",    "type" => "int",    "required" => true ),
                "id_dish"       => array( "field" => "id_dish",     "type" => "int",    "required" => true ),
                "quantity"      => array( "field" => "quantity",    "type" => "int",    "required" => true ),
                "price"         => array( "field" => "price",       "type" => "price",  "required" => true ),
                "total_price"   => array( "field" => "total_price", "type" => "price",  "required" => true ),
                "visible"       => array( "field" => "visible",     "type" => "int",    "required" => true ),
                "dish"          => array( "field" => "id_dish",     "type" => "table",  "required" => false, "join" => array("tdish", "name", "id") ),
            ),
            
            "fields" => array(
                "id_order"      => array( "type" => "int",    "default" => false,   "editable" => false ),
                "id_dish"       => array( "type" => "int",    "default" => false,   "editable" => false ),
                "quantity"      => array( "type" => "int",    "default" => 1,       "editable" => true ),
                "visible"       => array( "type" => "flag",   "default" => 1,       "editable" => true ),
            ),
            
            "filters" => array(
                "order"  => array( "field" => "id_order", "type" => "int_equals",  "required" => true ),
            ),
        
            "sort" => array(
                "priority"      => "torderdish.priority desc, torderdish.id",
                "create"        => "torderdish.id",
            ),
            
            "add_postprocessing" => "add_orderdish",
            
            "edit_postprocessing" => "edit_orderdish",
        ),
        
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
            "amount"    => array( "code" => 32,     "status_code" => 400,   "message" => "Not enough amount" ),
            "discount"  => array( "code" => 33,     "status_code" => 400,   "message" => "Invalid discount" ),
            "status"    => array( "code" => 34,     "status_code" => 400,   "message" => "Can't set this status" ),
            "courier"   => array( "code" => 35,     "status_code" => 400,   "message" => "Courier is not set" ),
                        
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