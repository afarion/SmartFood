<?

function DocConfigArray() 
{
    return array(

        "login" => array(
            
            "name" => "Аутентификация",
            
            "properties" => array(
                
                "type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "Тип пользователя. Обязательное поле.<br />1 - Администратор<br />2 - Оператор<br />3 - Повар"
                ),
                
                "login" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Логин для аутентификации. Обязательное поле." 
                ),
                
                "pass" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Пароль для аутентификации. Обязательное поле." 
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "auth/login/",
                    "params" => '{"type":"1","login":"admin","pass":"admin"}',
                ),
            
            "response" => '{"id":"1","type":"1","login":"admin","sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9"}',

        ),
    
        "itemtype" => array(
            
            "name" => "Тип объекта",
            
            "properties" => array(
                
                "user_id" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID пользователя. Обязательное поле."
                ),
                
                "user_type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "Тип пользователя. Обязательное поле.<br />1 - Администратор<br />2 - Оператор<br />3 - Повар"
                ),
                
                "user_sid" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Session ID, полученный при аутентификации. Обязательное поле."
                ),
                
                "order" => array(
                    "value" => "[priority|name|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />priority - по приоритету<br />name - по названию<br />create - по дате создания" 
                ),
            ),
            
            "request" => 
                array(
                    "link" => "list/itemtype/",
                    "params" => array(
                        "user_id" => 1,
                        "user_type" => 1,
                        "user_sid" => "9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9",
                        "order" => "priority",
                    ),
                ),
            
            "response" => '{"count":2,"items":[{"id":"1","name":"\u041f\u0440\u043e\u0434\u0443\u043a\u0442"},{"id":"2","name":"\u0420\u0430\u0441\u0445\u043e\u0434\u043d\u0438\u043a"}]}',
            
        ),
        
        "itemcategory" => array(
            
            "name" => "Категория объекта",
            
            "properties" => array(
                
                "user_id" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID пользователя. Обязательное поле."
                ),
                
                "user_type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "Тип пользователя. Обязательное поле.<br />1 - Администратор<br />2 - Оператор<br />3 - Повар"
                ),
                
                "user_sid" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Session ID, полученный при аутентификации. Обязательное поле."
                ),
                
                "order" => array(
                    "value" => "[priority|name|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />priority - по приоритету<br />name - по названию<br />create - по дате создания" 
                ),
            ),
            
            "request" => 
                array(
                    "link" => "list/itemcategory/",
                    "params" => array(
                        "user_id" => 1,
                        "user_type" => 1,
                        "user_sid" => "9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9",
                        "order" => "priority",
                    ),
                ),
            
            "response" => '{"count":4,"items":[{"id":"3","name":"\u041c\u044f\u0441\u043e"},{"id":"1","name":"\u0420\u044b\u0431\u0430"},{"id":"2","name":"\u041e\u0432\u043e\u0449\u0438"},{"id":"4","name":"\u0424\u0440\u0443\u043a\u0442\u044b"}]}',
            
        ),
        
        "unit" => array(
            
            "name" => "Еденицы измерения",
            
            "properties" => array(
                
                "user_id" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID пользователя. Обязательное поле."
                ),
                
                "user_type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "Тип пользователя. Обязательное поле.<br />1 - Администратор<br />2 - Оператор<br />3 - Повар"
                ),
                
                "user_sid" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Session ID, полученный при аутентификации. Обязательное поле."
                ),
                
                "order" => array(
                    "value" => "[priority|name|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />priority - по приоритету<br />name - по названию<br />create - по дате создания" 
                ),
            ),
            
            "request" => 
                array(
                    "link" => "list/unit/",
                    "params" => array(
                        "user_id" => 1,
                        "user_type" => 1,
                        "user_sid" => "9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9",
                        "order" => "priority",
                    ),
                ),
            
            "response" => '{"count":6,"items":[{"id":"2","name":"\u043a\u0438\u043b\u043e\u0433\u0440\u0430\u043c\u043c","abbr":"\u043a\u0433."},{"id":"3","name":"\u043b\u0438\u0442\u0440","abbr":"\u043b."},{"id":"1","name":"\u0448\u0442\u0443\u043a\u0430","abbr":"\u0448\u0442."},{"id":"5","name":"\u0431\u0443\u0442\u044b\u043b\u043a\u0430.","abbr":"\u0431\u0443\u0442."},{"id":"6","name":"\u043f\u0430\u0447\u043a\u0430.","abbr":"\u043f."},{"id":"4","name":"\u044f\u0449\u0438\u043a","abbr":"\u044f\u0449."}]}',
            
        ),
    
        /*
        "countries" => array(
            
            "name" => "Countries list",
            
            "properties" => array(
                
                "order" => array(
                    "value" => "[name|create]",
                    "type"  => "string", 
                    "descr" => "The order parameter specifies the method that will be used to order resources in the API response." 
                ),
            ),
            
            "request" => 
                array(
                    "link" => "list/country/",
                    "params" => array(
                        "order" => "name",
                    ),
                ),
            
            "response" => '{"count":1,"items":[{"id":"1","name":"USA"}]}',
            
        ),
        
        "cities" => array(
            
            "name" => "Search cities",
            
            "properties" => array(
                
                "part" => array( 
                    "value" => "[id, name, country, tax, image, lat, lon, gps]",      
                    "type"  => "string",    
                    "descr" => "Part parameter specifies a comma-separated list of one or more search resource properties that the API response will include." 
                ),
                
                "q" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "The q parameter specifies the query term to search for." 
                ),
                
                "country" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "The country parameter specifies the country ID of API response resources." 
                ),
                
                "order" => array(
                    "value" => "[name|create]",
                    "type"  => "string", 
                    "descr" => "The order parameter specifies the method that will be used to order resources in the API response." 
                ),
                
                "count" => array(
                    "value" => "",
                    "type"  => "unsigned int", 
                    "descr" => "The count parameter specifies the maximum number of items that should be returned in the result set." 
                ),
                
                "offset" => array(
                    "value" => "",
                    "type"  => "unsigned int", 
                    "descr" => "The offset parameter specifies the items start position in the result set." 
                ),
                
                "page" => array(
                    "value" => "",
                    "type"  => "unsigned int", 
                    "descr" => "The page parameter specifies a number of page in the result set." 
                ),
            ),
            
            "request" => 
                array(
                    "link" => "search/city/",
                    "params" => array(
                        "part" => "id,name,country,tax,image,gps",
                        "q" => "a",
                        "country" => 1,
                        "order" => "name",
                    ),
                ),
            
            "response" => '{"count":3,"items":[{"id":"3","name":"Las Vegas","country":"1","tax":"8.15","image":"http:\/\/momentodeals.com\/images\/las_vegas.png","gps":"36.169941, -115.139830"},{"id":"1","name":"Los Angeles","country":"1","tax":"9","image":"http:\/\/momentodeals.com\/images\/los_angeles.png","gps":"34.052234, -118.243685"},{"id":"2","name":"San Francisco","country":"1","tax":"8.75","image":"http:\/\/momentodeals.com\/images\/san_francisco.png","gps":"37.774929, -122.419416"}]}',

        ),
        
        "durations" => array(
            
            "name" => "Durations list",
            
            "properties" => array(
                
                "order" => array(
                    "value" => "[name|create]",
                    "type"  => "string", 
                    "descr" => "The order parameter specifies the method that will be used to order resources in the API response." 
                ),
            ),
            
            "request" => 
                array(
                    "link" => "list/duration/",
                    "params" => array(
                        "order" => "create",
                    ),
                ),
            
            "response" => '{"count":6,"items":[{"id":"1","name":"HalfDay","multiplier":"1"},{"id":"2","name":"1 Night","multiplier":"1"},{"id":"3","name":"2 Nights","multiplier":"2"},{"id":"4","name":"3 Nights","multiplier":"3"},{"id":"5","name":"4 Nights","multiplier":"4"},{"id":"6","name":"5 Nights","multiplier":"5"}]}',

        
        ),
        
        "roomtypes" => array(
            
            "name" => "Room types list",
            
            "properties" => array(
                
                "order" => array(
                    "value" => "[name|create]",
                    "type"  => "string", 
                    "descr" => "The order parameter specifies the method that will be used to order resources in the API response." 
                ),
            ),
            
            "request" => 
                array(
                    "link" => "list/roomtype/",
                    "params" => array(
                        "order" => "create",
                    ),
                ),
            
            "response" => '{"count":3,"items":[{"id":"1","name":"King"},{"id":"2","name":"Queen"},{"id":"3","name":"2 Beds"}]}',

        
        ),
        
        "hotels" => array(
            
            "name" => "Search hotels",
            
            "properties" => array(
                
                "part" => array( 
                    "value" => "[id, name, rating, email, gps, phone, address, image, poc, short, full, notes]",      
                    "type"  => "string",    
                    "descr" => "Part parameter specifies a comma-separated list of one or more search resource properties that the API response will include." 
                ),
                
                "deals" => array(
                    "value" => "[id, name, hotel, price, tonight_price, description, duration, roomtype, checkout, date_finish]",
                    "type"  => "string", 
                    "descr" => "Part parameter specifies a comma-separated list of one or more search resource properties that the API response will include to each deal of hotel." 
                ),
                
                "services" => array(
                    "value" => "[id, name, price, tonight_price, description]",
                    "type"  => "string", 
                    "descr" => "Part parameter specifies a comma-separated list of one or more search resource properties that the API response will include to each service of each deal." 
                ),
                
                "q" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "The q parameter specifies the query term to search for." 
                ),
                
                "id" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "The id parameter specifies a comma-separated list of the hotels ID(s) for the resource(s) that are being retrieved." 
                ),
                
                "city" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "The city parameter specifies a city ID for the resource(s) that are being retrieved." 
                ),
                
                "roomtype" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "The roomtype parameter specifies a comma-separated list of the deal roomtype ID(s) for the resource(s) that are being retrieved. Only hotels with active deals will be included to response." 
                ),
                
                "order" => array(
                    "value" => "[name|create|rating|price|date]",
                    "type"  => "string", 
                    "descr" => "The order parameter specifies the method that will be used to order resources in the API response.<br />name - order by hotel name.<br />create - order by hotel create date.<br />rating - order by hotel rating. Hotel with maximal rating will be at first place.<br />price - order by minimal deal tonight price. Only hotels with active deals will be included to response.<br />date - order by nearest deal finish date. Only hotels with active deals will be included to response." 
                ),
                
                "count" => array(
                    "value" => "",
                    "type"  => "unsigned int", 
                    "descr" => "The count parameter specifies the maximum number of items that should be returned in the result set." 
                ),
                
                "offset" => array(
                    "value" => "",
                    "type"  => "unsigned int", 
                    "descr" => "The offset parameter specifies the items start position in the result set." 
                ),
                
                "page" => array(
                    "value" => "",
                    "type"  => "unsigned int", 
                    "descr" => "The page parameter specifies a number of page in the result set." 
                ),
            ),
            
            "request" => 
                array(
                    "link" => "search/hotel/",
                    "params" => array(
                        "part" => "rating,email,gps,phone,address,image,poc,short,full,notes",
                        "deals" => "price,tonight_price,description",
                        "services" => "price,tonight_price,description",
                        "q" => "a",
                        "id" => "1,10",
                        "order" => "name",
                    ),
                ),
            
            "response" => '{"count":2,"items":[{"id":"1","name":"Grand Budapest","rating":"4","email":"grandbudapest@mail.com","gps":"34.019672, -118.490135","phone":"1234567890","address":null,"image":null,"poc":null,"short":null,"full":null,"notes":"note"},{"id":"10","name":"Hotel In Vegas","rating":"3","email":"vegasedit@mail.com","gps":"123.4567, 234.5677","phone":"4159099099","address":"342 Grand Ave San Francisco CA 94122","image":"10.jpg","poc":null,"short":"Complimentary WiFi\r\n24-hour fitness center with cardio and weight equipment\r\nPets OK\r\n","full":"Spunky, spirited, seriously unique. People tell us staying at Hotel Triton feels a lot like staying with your most fashionable friend. You know, the one with an eclectic apartment just a few steps from Union Square and Chinatown, who\u00e2\u0080\u0099s delighted to share insider tips on things to do and places to go and invites you to meet all sorts of interesting people over late afternoon glass of wine or a cool local microbrew.\r\n\r\nHotel Triton delights with cheerful guestrooms featuring luxurious Frette linens and organic snack bars, funky celebrity-designed suites (ice cream, anyone?) and a no-fee pet policy that makes bringing along your prized pup easy and affordable. Add the yoga mat in every guestroom and the at-the-ready bag butler who\u00e2\u0080\u0099ll happily fetch your shopping bags at any Union Square shop or boutique and we think you\u00e2\u0080\u0099ll agree: you have a new friend in San Francisco.","notes":"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."}]}',

        ),
        
        "registration" => array(
            
            "name" => "Auth registration",
            
            "properties" => array(
                
                "name" => array( 
                    "value" => "",      
                    "type"  => "string",    
                    "descr" => "User name. Required field, that must contain only letters, space or point symbols."
                ),
                
                "email" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "User email. Required field, that must be a valid email address. Unique for each user." 
                ),                
                
                "phone" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "User phone. Required field, that must contain only digits, space, point, dash or parentheses symbols." 
                ),
                
                "pass" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "User password. Required field." 
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "auth/registration/",
                    "params" => '{"name":"John Black","email":"johnblack@gmail.ru","phone":"(012) 222-33-44","pass":"012asd!F9"}',
                ),
            
            "response" => '{"id":"2","name":"John Black","email":"johnblack@gmail.ru","phone":"(012) 222-33-44","hash":"a32443a9fd7b5652762a5836dfed092a2c818275","last_4_numbers":null}',

        ),
        
        "login" => array(
            
            "name" => "Auth log in",
            
            "properties" => array(
                
                "email" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "User email. Required field, that must be a valid email address. Unique for each user." 
                ),
                
                "pass" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "User password. Required field." 
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "auth/login/",
                    "params" => '{"email":"johnblack@gmail.ru","pass":"012asd!F9"}',
                ),
            
            "response" => '{"id":"2","name":"John Black","email":"johnblack@gmail.ru","phone":"(012) 222-33-44","hash":"a32443a9fd7b5652762a5836dfed092a2c818275","last_4_numbers":null}',

        ),
        
        "login_id" => array(
            
            "name" => "Auth log in by ID",
            
            "properties" => array(
                
                "id" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "User id. Required field." 
                ),
                
                "hash" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "User hash. Required field." 
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "auth/login/",
                    "params" => '{"id":"2","hash":"a32443a9fd7b5652762a5836dfed092a2c818275"}',
                ),
            
            "response" => '{"id":"2","name":"John Black","email":"johnblack@gmail.ru","phone":"(012) 222-33-44","hash":"a32443a9fd7b5652762a5836dfed092a2c818275","last_4_numbers":null}',

        ),
        
        "login_fb" => array(
            
            "name" => "Auth log in by FB",
            
            "properties" => array(
                
                "fb_id" => array(
                    "value" => "",
                    "type"  => "bigint", 
                    "descr" => "Facebook user id. Required field." 
                ),
                
                "fb_token" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Facebook user access token. Required field." 
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "auth/fb/",
                    "params" => '{"fb_id":"123456789","fb_token":"abcdefghijklmnopqrst|ABSDEFG1234567890"}',
                ),
            
            "response" => '{"id":"2","name":"John Black","email":"johnblack@gmail.ru","phone":"(012) 222-33-44","hash":"a32443a9fd7b5652762a5836dfed092a2c818275","last_4_numbers":null}',

        ),
        
        "update" => array(
            
            "name" => "Auth update",
            
            "properties" => array(
                
                "id" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "User id. Required field." 
                ),
                
                "hash" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "User hash. Required field." 
                ),
                
                "name" => array( 
                    "value" => "",      
                    "type"  => "string",    
                    "descr" => "User name. Must contain only letters, space or point symbols."
                ),
                
                "email" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "User email. Must be a valid email address. Will be updated only for facebook users." 
                ),                
                
                "phone" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "User phone. Must contain only digits, space, point, dash or parentheses symbols." 
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "auth/update/",
                    "params" => '{"id":"2","hash":"a32443a9fd7b5652762a5836dfed092a2c818275","name":"John Black","phone":"(012) 222-33-44"}',
                ),
            
            "response" => '{"id":"2","name":"John Black","email":"johnblack@gmail.ru","phone":"(012) 222-33-44","hash":"a32443a9fd7b5652762a5836dfed092a2c818275","facebook":"0","payment_method_token":null,"last_4_numbers":null}',

        ),
        
        "booking_price" => array(
            
            "name" => "Booking price",
            
            "properties" => array(
                
                "hotel" => array( 
                    "value" => "",      
                    "type"  => "int",    
                    "descr" => "Hotel ID. Required parameter."
                ),
                
                "deal" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "Room deal ID. Required parameter." 
                ),                
                
                "services" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Parameter specifies a comma-separated list of deal services IDs, selected on client side." 
                ),
                
            ),
            
            "request" => 
                array(
                    "link" => "booking/price/",
                    "params" => array(
                        "hotel" => "46",
                        "deal" => "2",
                        "services" => "3,4",
                    ),
                ),
            
            "response" => '{"hotel_name":"Mirage","hotel_phone":"702-791-7111","hotel_address":"3400 S Las Vegas Blvd, Las Vegas, NV 89109, United States","submit_date":"2016-05-20 00:21:39","duration":"HalfDay","checkout":"8 am","tax":8.15,"subtotal_price":36100,"tax_price":2942,"total_price":39042}',

        ),
        
        "booking_order" => array(
            
            "name" => "Booking order",
            
            "properties" => array(
                
                "user_id" => array( 
                    "value" => "",      
                    "type"  => "int",    
                    "descr" => "User ID. Required parameter."
                ),
                
                "hash" => array( 
                    "value" => "",      
                    "type"  => "string",    
                    "descr" => "User hash code. Required parameter."
                ),
                
                "hotel" => array( 
                    "value" => "",      
                    "type"  => "int",    
                    "descr" => "Hotel ID. Required parameter."
                ),
                
                "deal" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "Room deal ID. Required parameter." 
                ),                
                
                "services" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Parameter specifies a comma-separated list of deal services IDs, selected on client side." 
                ),
                
                "user_notes" => array( 
                    "value" => "",      
                    "type"  => "string",    
                    "descr" => "User notes."
                ),
                
                "total_price" => array( 
                    "value" => "",      
                    "type"  => "int",    
                    "descr" => "Order total price in cents. Required parameter."
                ),
                
                "payment_method_token" => array( 
                    "value" => "",      
                    "type"  => "string",    
                    "descr" => "Payment method token."
                ),
                
                "last_4_numbers" => array( 
                    "value" => "",      
                    "type"  => "string",    
                    "descr" => "Last 4 numbers."
                ),
                
                "fist_name" => array( 
                    "value" => "",      
                    "type"  => "string",    
                    "descr" => "Fist name. Required parameter."
                ),
                
                "last_name" => array( 
                    "value" => "",      
                    "type"  => "string",    
                    "descr" => "Last name. Required parameter."
                ),
                
                "hotel_member_id" => array( 
                    "value" => "",      
                    "type"  => "string",    
                    "descr" => "Hotel Member ID."
                ),
                
                "guest_full_name" => array( 
                    "value" => "",      
                    "type"  => "string",    
                    "descr" => "Guest Full Name. Required parameter."
                ),
                
                "retain" => array( 
                    "value" => "",      
                    "type"  => "int",    
                    "descr" => "Retain flag. If retain = 1, payment_method_token and last_4_numbers will be saved."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "booking/order/",
                    "params" => '{"user_id":"1","hash":"a42bb10e6c9d37ce2923fdd805b3d3bf32645448","hotel":"46","deal":"2","services":"3,4","user_notes":"some text","total_price":39042,"payment_method_token":"AV4aXDwaAJ7p6PK5SRyaiyyCR0F","last_4_numbers":1111,"fist_name":"Ivan","last_name":"Ivanov","hotel_member_id":"test","guest_full_name":"name","retain":1}',
                ),
            
            "response" => '{"id":1,"total_price":39042,"submit_date":"2016-04-28 00:01:13","message":"Succeeded!"}',

        ),
        
        "orders" => array(
            
            "name" => "Search orders",
            
            "properties" => array(
            
                "user_id" => array( 
                    "value" => "",      
                    "type"  => "int",    
                    "descr" => "User ID. Required parameter."
                ),
                
                "hash" => array( 
                    "value" => "",      
                    "type"  => "string",    
                    "descr" => "User hash code. Required parameter."
                ),
                
                "part" => array( 
                    "value" => "[id, hotel_name, hotel_phone, hotel_address, duration, checkout, status, user_name, manager_name, room_name, user_phone, user_email, tax, tax_price, subtotal_price, total_price, submit_date]",      
                    "type"  => "string",    
                    "descr" => "Part parameter specifies a comma-separated list of one or more search resource properties that the API response will include." 
                ),
                
                "services" => array(
                    "value" => "[id, name, price, tonight_price, description]",
                    "type"  => "string", 
                    "descr" => "Part parameter specifies a comma-separated list of one or more search resource properties that the API response will include to each service of each order." 
                ),
                
                "order" => array(
                    "value" => "[date|create]",
                    "type"  => "string", 
                    "descr" => "The order parameter specifies the method that will be used to order resources in the API response." 
                ),
                
                "count" => array(
                    "value" => "",
                    "type"  => "unsigned int", 
                    "descr" => "The count parameter specifies the maximum number of items that should be returned in the result set." 
                ),
                
                "offset" => array(
                    "value" => "",
                    "type"  => "unsigned int", 
                    "descr" => "The offset parameter specifies the items start position in the result set." 
                ),
                
                "page" => array(
                    "value" => "",
                    "type"  => "unsigned int", 
                    "descr" => "The page parameter specifies a number of page in the result set." 
                ),
            ),
            
            "request" => 
                array(
                    "link" => "search/order/",
                    "params" => array(
                        "user_id" => "1",
                        "hash" => "a42bb10e6c9d37ce2923fdd805b3d3bf32645448",
                        "part" => "id,hotel_name,duration,status,manager_name,room_name,total_price,submit_date",
                        "services" => "price,tonight_price,description",
                        "order" => "create",
                    ),
                ),
            
            "response" => '{"count":1,"items":[{"id":"1","hotel_name":"Mirage","duration":"HalfDay","status":"Pending ","manager_name":"Sam York","room_name":"Resort Standard Room","total_price":"390.42","submit_date":"2016-04-28 00:01:13","services":[{"id":"1","name":"Fax\/photocopying","price":"0.00","tonight_price":"5.00","description":""},{"id":"2","name":"Sauna","price":"56.00","tonight_price":"356.00","description":"Saunas relieve stress."}]}]}',

        ),
        
        "errors" => array(
        
            "name" => "API Errors",
            
            "errors" => array(
                
                ERROR_CODE_REQUEST  => ERROR_TEXT_REQUEST,
                ERROR_CODE_METHOD   => ERROR_TEXT_METHOD,
                ERROR_CODE_COUNT    => ERROR_TEXT_COUNT,
                ERROR_CODE_OFFSET   => ERROR_TEXT_OFFSET,
                ERROR_CODE_PAGE     => ERROR_TEXT_PAGE,
                ERROR_CODE_RESP     => ERROR_TEXT_RESP,  
                ERROR_CODE_HASH     => ERROR_TEXT_HASH,
                ERROR_CODE_ORDER    => ERROR_TEXT_ORDER,
                
            ),
        ),
        */
        
        "errors" => array(
        
            "name" => "API Errors",
            
            "errors" => array(
                "request"   => array( "code" => 1,      "status_code" => 400,   "message" => "Wrong request" ),
                "method"    => array( "code" => 2,      "status_code" => 400,   "message" => "Wrong request method" ),
                
                "count"     => array( "code" => 10,     "status_code" => 400,   "message" => "Wrong 'count' value" ),
                "offset"    => array( "code" => 11,     "status_code" => 400,   "message" => "Wrong 'offset' value" ),
                "page"      => array( "code" => 12,     "status_code" => 400,   "message" => "Wrong 'page' value" ),
                
                "resp"      => array( "code" => 20,     "status_code" => 400,   "message" => "Invalid response" ),
                "action"    => array( "code" => 21,     "status_code" => 400,   "message" => "Invalid action" ),
                "user"      => array( "code" => 22,     "status_code" => 400,   "message" => "Invalid user data" ),
                
                "sid"       => array( "code" => 30,     "status_code" => 401,   "message" => "Wrong user sid" ),
                "perm"      => array( "code" => 31,     "status_code" => 403,   "message" => "You do not have permission for this action" ),
                
                "undefined" => array( "code" => 100,    "status_code" => 404,   "message" => "Undefined error" ),
                "not_found" => array( "code" => 101,    "status_code" => 404,   "message" => "Item not found" ),
            ),
        ),
        
        "auth-errors" => array(
            
            "name" => "Auth Errors",
            
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
        
        ),
        
    );

}

?>