<?

function DocConfigArray() 
{
    return array(

        "auth" => array(
            
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
                    "link" => "auth/",
                    "params" => '{"type":"1","login":"admin","pass":"admin"}',
                    "test_file" => "auth.php"
                ),
            
            "response" => '{"id":"1","type":"1","login":"admin","sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9"}',

        ),
        
        // ====================================================================================================
        // UNIT
    
        "unit" => array(
            
            "name" => "Еденицы измерения. View",
            
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
                
                "action" => array(
                    "value" => "view",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае просмотр (view). Обязательное поле."
                ),
                
                "order" => array(
                    "value" => "[priority|name|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />priority - по приоритету<br />name - по названию<br />create - по дате создания" 
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "unit/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view","order":"priority"}',
                    "test_file" => "unit_view.php"
                ),
            
            "response" => '{"count":6,"items":[{"id":"2","name":"\u043a\u0438\u043b\u043e\u0433\u0440\u0430\u043c\u043c","abbr":"\u043a\u0433."},{"id":"3","name":"\u043b\u0438\u0442\u0440","abbr":"\u043b."},{"id":"1","name":"\u0448\u0442\u0443\u043a\u0430","abbr":"\u0448\u0442."},{"id":"5","name":"\u0431\u0443\u0442\u044b\u043b\u043a\u0430.","abbr":"\u0431\u0443\u0442."},{"id":"6","name":"\u043f\u0430\u0447\u043a\u0430.","abbr":"\u043f."},{"id":"4","name":"\u044f\u0449\u0438\u043a","abbr":"\u044f\u0449."}]}',
            
        ),
        
        // ====================================================================================================
        // ITEM TYPE
        
        "itemtype_view" => array(
            
            "name" => "Тип объекта. View",
            
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
                
                "action" => array(
                    "value" => "view",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае просмотр (view). Обязательное поле."
                ),
                
                "order" => array(
                    "value" => "[priority|name|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />priority - по приоритету<br />name - по названию<br />create - по дате создания" 
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "itemtype/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view"}',
                    "test_file" => "itemtype_view.php"
                ),
            
            "response" => '{"count":3,"items":[{"id":"1","name":"\u041f\u0440\u043e\u0434\u0443\u043a\u0442","visible":"1"},{"id":"2","name":"\u0420\u0430\u0441\u0445\u043e\u0434\u043d\u0438\u043a","visible":"1"},{"id":"3","name":"\u0411\u044b\u0442\u043e\u0432\u0430\u044f \u0445\u0438\u043c\u0438\u044f","visible":"1"}]}',
            
        ),
        
        "itemtype_add" => array(
            
            "name" => "Тип объекта. Add",
            
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
                
                "action" => array(
                    "value" => "add",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае добавление (add). Обязательное поле."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Название типа. Обязательное поле."
                ),
                
                "visible" => array(
                    "value" => "0 или 1 ",
                    "type"  => "flag", 
                    "descr" => "Видимость типа."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "itemtype/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"add","name":"Type Name","visible":"1"}',
                    "test_file" => "itemtype_add.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        "itemtype_edit" => array(
            
            "name" => "Тип объекта. Edit",
            
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
                
                "action" => array(
                    "value" => "add",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае редактирование (edit). Обязательное поле."
                ),
                
                "id" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID редактируемого типа. Обязательное поле."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Название типа."
                ),
                
                
                "visible" => array(
                    "value" => "0 или 1 ",
                    "type"  => "flag", 
                    "descr" => "Видимость типа."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "itemtype/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"edit","id":"1","name":"Type Name"}',
                    "test_file" => "itemtype_edit.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        // ====================================================================================================
        // ITEM CATEGORY
        
        "itemcategory_view" => array(
            
            "name" => "Категория объекта. View",
            
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
                
                "action" => array(
                    "value" => "view",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае просмотр (view). Обязательное поле."
                ),
                
                "type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID типа. Если указан, будут возвращены категории только этого типа."
                ),
                
                "order" => array(
                    "value" => "[priority|name|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />priority - по приоритету<br />name - по названию<br />create - по дате создания" 
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "itemcategory/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view","type":"1"}',
                    "test_file" => "itemcategory_view.php"
                ),
            
            "response" => '{"count":4,"items":[{"id":"1","name":"\u0420\u044b\u0431\u0430","id_type":"1"},{"id":"2","name":"\u041e\u0432\u043e\u0449\u0438","id_type":"1"},{"id":"3","name":"\u041c\u044f\u0441\u043e","id_type":"1"},{"id":"4","name":"\u0424\u0440\u0443\u043a\u0442\u044b","id_type":"1"}]}',
            
        ),
        
        "itemcategory_add" => array(
            
            "name" => "Категория объекта. Add",
            
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
                
                "action" => array(
                    "value" => "add",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае добавление (add). Обязательное поле."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Название категории. Обязательное поле."
                ),
                
                "id_type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID типа. Обязательное поле."
                ),
                
                "visible" => array(
                    "value" => "0 или 1 ",
                    "type"  => "flag", 
                    "descr" => "Видимость категории."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "itemcategory/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"add","name":"Category Name","id_type":"1","visible":"1"}',
                    "test_file" => "itemcategory_add.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        "itemcategory_edit" => array(
            
            "name" => "Категория объекта. Edit",
            
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
                
                "action" => array(
                    "value" => "edit",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае редактирование (edit). Обязательное поле."
                ),
                
                "id" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID редактируемой категории. Обязательное поле."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Название категории."
                ),
                
                "id_type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID типа."
                ),
                
                "visible" => array(
                    "value" => "0 или 1 ",
                    "type"  => "flag", 
                    "descr" => "Видимость категории."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "itemcategory/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"edit","name":"Category Name","id_type":"1","visible":"1"}',
                    "test_file" => "itemcategory_edit.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        // ====================================================================================================
        // ITEM
        
        "item_view" => array(
            
            "name" => "Объекты. View",
            
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
                
                "action" => array(
                    "value" => "view",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае просмотр (view). Обязательное поле."
                ),
                
                "part" => array(
                    "value" => "[type|category|unit]",
                    "type"  => "string", 
                    "descr" => "Дополнительные поля, перечисленые через запятую. Если указаны, будут добавлены в ответ.<br />
                                &#8226; type - название типа объекта<br />
                                &#8226; category - название категории объекта<br />
                                &#8226; unit - еденица измерения, сокращение" 
                ),
                
                "type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID типа. Если указан, будут возвращены объекты только этого типа."
                ),
                
                "category" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID категории. Если указан, будут возвращены объекты только этой категории."
                ),
                
                "order" => array(
                    "value" => "[priority|name|amount|price|price_desc|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />
                                &#8226; priority - по приоритету<br />
                                &#8226; name - по названию<br />
                                &#8226; amount - по колличеству на складе<br />
                                &#8226; price - по возрастанию цены<br />
                                &#8226; price_desc - по убыванию цены<br />
                                &#8226; create - по дате создания" 
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "item/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view","part":"type,category,unit","order":"priority"}',
                    "test_file" => "item_view.php"
                ),
            
            "response" => '{"count":5,"items":[{"id":"1","name":"Item 1","id_type":"1","id_category":"1","id_unit":"1","amount":"0.000","price":"0.00","visible":"1","type":"\u041f\u0440\u043e\u0434\u0443\u043a\u0442","category":"\u0420\u044b\u0431\u0430","unit":"\u0448\u0442."},{"id":"5","name":"Item 2","id_type":"1","id_category":"2","id_unit":"1","amount":"0.000","price":"0.00","visible":"1","type":"\u041f\u0440\u043e\u0434\u0443\u043a\u0442","category":"\u041e\u0432\u043e\u0449\u0438","unit":"\u0448\u0442."},{"id":"6","name":"Item 3","id_type":"1","id_category":"2","id_unit":"1","amount":"1.000","price":"0.00","visible":"1","type":"\u041f\u0440\u043e\u0434\u0443\u043a\u0442","category":"\u041e\u0432\u043e\u0449\u0438","unit":"\u0448\u0442."},{"id":"8","name":"Item 4","id_type":"1","id_category":"2","id_unit":"1","amount":"1.800","price":"0.00","visible":"1","type":"\u041f\u0440\u043e\u0434\u0443\u043a\u0442","category":"\u041e\u0432\u043e\u0449\u0438","unit":"\u0448\u0442."},{"id":"9","name":"Item 5","id_type":"1","id_category":"2","id_unit":"1","amount":"1.561","price":"0.00","visible":"1","type":"\u041f\u0440\u043e\u0434\u0443\u043a\u0442","category":"\u041e\u0432\u043e\u0449\u0438","unit":"\u0448\u0442."}]}',
            
        ),
        
        "item_add" => array(
            
            "name" => "Объекты. Add",
            
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
                
                "action" => array(
                    "value" => "add",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае добавление (add). Обязательное поле."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Название объекта. Обязательное поле."
                ),
                
                "id_type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID типа объекта. Обязательное поле."
                ),
                
                "id_category" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID категории объекта. Обязательное поле."
                ),
                
                "id_unit" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID единицы измерения объекта. Обязательное поле."
                ),
                
                /*
                "amount" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Колличество на складе."
                ),
                */
                
                "price" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Последняя цена за единицу."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "item/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"add","name":"Item Name","id_type":"1","id_category":"1","id_unit":"1","amount":"0","price":"52.85"}',
                    "test_file" => "item_add.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        "item_edit" => array(
            
            "name" => "Объекты. Edit",
            
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
                
                "action" => array(
                    "value" => "edit",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае редактирование (edit). Обязательное поле."
                ),
                
                "id" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID редактируемого объекта. Обязательное поле."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Название объекта."
                ),
                
                "id_type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID типа объекта."
                ),
                
                "id_category" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID категории объекта."
                ),
                
                "id_unit" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID единицы измерения объекта."
                ),
                
                /*
                "amount" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Колличество на складе."
                ),
                
                "price" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Последняя цена за единицу."
                ),
                */
                
                "visible" => array(
                    "value" => "0 или 1 ",
                    "type"  => "flag", 
                    "descr" => "Видимость объекта."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "item/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"edit","id":"1","name":"Item Name","id_type":"1","id_category":"1","id_unit":"1"}',
                    "test_file" => "item_edit.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
    
        // ====================================================================================================
        // PROVIDER
        
        "provider_view" => array(
            
            "name" => "Поставщики. View",
            
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
                
                "action" => array(
                    "value" => "view",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае просмотр (view). Обязательное поле."
                ),
                
                "order" => array(
                    "value" => "[priority|name|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />priority - по приоритету<br />name - по названию<br />create - по дате создания" 
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "provider/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view"}',
                    "test_file" => "provider_view.php"
                ),
            
            "response" => '{"count":3,"items":[{"id":"1","name":"\u041f\u043e\u0441\u0442\u0430\u0432\u0449\u0438\u043a \u043f\u0435\u0440\u0432\u044b\u0439","notes":"\u041e\u043d \u043f\u0435\u0440\u0432\u044b\u0439!","visible":"1"},{"id":"2","name":"\u041f\u043e\u0441\u0442\u0430\u0432\u0449\u0438\u043a 2","notes":"\u0434\u043e\u043b\u0436\u0435\u043d \u0434\u0435\u043d\u0435\u0433","visible":"1"},{"id":"3","name":"\u041f\u043e\u0441\u0442\u0430\u0432\u0449\u0438\u043a 3","notes":"","visible":"1"}]}',
            
        ),
        
        "provider_add" => array(
            
            "name" => "Поставщики. Add",
            
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
                
                "action" => array(
                    "value" => "add",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае добавление (add). Обязательное поле."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Имя поставщика. Обязательное поле."
                ),
                
                "notes" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Заметки."
                ),
                
                "visible" => array(
                    "value" => "0 или 1 ",
                    "type"  => "flag", 
                    "descr" => "Видимость поставщика."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "provider/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"add","name":"Provider 1","notes":"The first"}',
                    "test_file" => "provider_add.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        "provider_edit" => array(
            
            "name" => "Поставщики. Edit",
            
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
                
                "action" => array(
                    "value" => "add",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае редактирование (edit). Обязательное поле."
                ),
                
                "id" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID редактируемого поставщика. Обязательное поле."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Имя поставщика."
                ),
                
                "notes" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Заметки."
                ),
                
                "visible" => array(
                    "value" => "0 или 1 ",
                    "type"  => "flag", 
                    "descr" => "Видимость поставщика."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "provider/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"edit","id":"1","name":"Provider 1","notes":"The first"}',
                    "test_file" => "provider_edit.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        // ====================================================================================================
        // EMPLOYEE TYPE
    
        "employeetype" => array(
            
            "name" => "Типы сотрудников. View",
            
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
                
                "action" => array(
                    "value" => "view",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае просмотр (view). Обязательное поле."
                ),
                
                "order" => array(
                    "value" => "[priority|name|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />priority - по приоритету<br />name - по названию<br />create - по дате создания" 
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "employeetype/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view","order":"priority"}',
                    "test_file" => "employeetype_view.php"
                ),
            
            "response" => '{"count":6,"items":[{"id":"1","name":"\u0414\u0438\u0440\u0435\u043a\u0442\u043e\u0440"},{"id":"2","name":"\u0428\u0435\u0444-\u043f\u043e\u0432\u0430\u0440"},{"id":"3","name":"\u0410\u0434\u043c\u0438\u043d\u0438\u0441\u0442\u0440\u0430\u0442\u043e\u0440"},{"id":"4","name":"\u041f\u043e\u0432\u0430\u0440"},{"id":"5","name":"\u041e\u043f\u0435\u0440\u0430\u0442\u043e\u0440"},{"id":"6","name":"\u0414\u043e\u0441\u0442\u0430\u0432\u0449\u0438\u043a"}]}',
            
        ),
    
        // ====================================================================================================
        // EMPLOYEE
        
        "employee_view" => array(
            
            "name" => "Сотрудники. View",
            
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
                
                "action" => array(
                    "value" => "view",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае просмотр (view). Обязательное поле."
                ),
                
                "type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID типа. Если указан, будут возвращены сотрудники только этого типа."
                ),
                
                "order" => array(
                    "value" => "[priority|name|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />priority - по приоритету<br />name - по названию<br />create - по дате создания" 
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "employee/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view","type":"1"}',
                    "test_file" => "employee_view.php"
                ),
            
            "response" => '{"count":3,"items":[{"id":"1","id_type":"1","first_name":"\u0410\u043b\u0435\u043a\u0441\u0430\u043d\u0434\u0440","last_name":"\u0424\u0430\u0440\u0438\u043e\u043d","phone":"0962357575","phone_ex":"0668605699","skype":"aleksairdis","address":null,"email":"farion.alexandr@gmail.com","birthday":"1988-02-21","comment":null,"visible":"1"},{"id":"2","id_type":"1","first_name":"\u0412\u0430\u0434\u0438\u043c","last_name":"\u041f\u0438\u0442\u0435\u043d\u043a\u043e","phone":"0962772096","phone_ex":"0632778763","skype":"\r\nvadim.pitenko","address":null,"email":"vadim.pitenko@gmail.com","birthday":"1989-10-06","comment":null,"visible":"1"},{"id":"3","id_type":"1","first_name":"\u041c\u0430\u0440\u0438\u043d\u0430","last_name":"\u0424\u0430\u0440\u0438\u043e\u043d","phone":"0675573133","phone_ex":null,"skype":"live:marinafarion","address":null,"email":"marinafarion@gmail.com","birthday":"1991-05-29","comment":null,"visible":"1"}]}',
            
        ),
        
        "employee_add" => array(
            
            "name" => "Сотрудники. Add",
            
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
                
                "action" => array(
                    "value" => "add",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае добавление (add). Обязательное поле."
                ),
                
                "id_type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID типа. Обязательное поле."
                ),
                
                "first_name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Имя сотрудника. Обязательное поле."
                ),
                
                "last_name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Фамилия сотрудника. Обязательное поле."
                ),
                
                "phone" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Телефон сотрудника."
                ),
                
                "phone_ex" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Дополнительный телефон сотрудника."
                ),
                
                "skype" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Skype сотрудника."
                ),
                
                "address" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Адрес сотрудника."
                ),
                
                "email" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "E-mail сотрудника."
                ),
                
                "birthday" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Дата рождения сотрудника. Формат: YYYY-MM-DD."
                ),
                
                "comment" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Комментарий."
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "employee/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"add","first_name":"Иван","last_name":"Иванов","id_type":"1"}',
                    "test_file" => "employee_add.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        "employee_edit" => array(
            
            "name" => "Сотрудники. Edit",
            
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
                
                "action" => array(
                    "value" => "edit",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае редактирование (edit). Обязательное поле."
                ),
                
                "id" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID редактируемого сотрудника. Обязательное поле."
                ),
                
                "id_type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID типа."
                ),
                
                "first_name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Имя сотрудника."
                ),
                
                "last_name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Фамилия сотрудника."
                ),
                
                "phone" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Телефон сотрудника."
                ),
                
                "phone_ex" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Дополнительный телефон сотрудника."
                ),
                
                "skype" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Skype сотрудника."
                ),
                
                "address" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Адрес сотрудника."
                ),
                
                "email" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "E-mail сотрудника."
                ),
                
                "birthday" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Дата рождения сотрудника. Формат: YYYY-MM-DD."
                ),
                
                "comment" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Комментарий."
                ),
                
                "visible" => array(
                    "value" => "0 или 1 ",
                    "type"  => "flag", 
                    "descr" => "Видимость сотрудника."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "employee/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"edit","first_name":"Андрей","id_type":"1","visible":"1"}',
                    "test_file" => "employee_edit.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        // ====================================================================================================
        // USER
        
        "user_view" => array(
            
            "name" => "Пользователи. View",
            
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
                
                "action" => array(
                    "value" => "view",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае просмотр (view). Обязательное поле."
                ),
                
                "order" => array(
                    "value" => "[create|name]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />create - по дате создания<br />name - по названию" 
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "user/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view"}',
                    "test_file" => "user_view.php"
                ),
            
            "response" => '{"count":3,"items":[{"id":"1","name":"\u0412\u0430\u0441\u044f","phone":"11111","email":"vasya@mail.ru","discount_fixed":"10","discount_stored":null,"total_balance":null,"comment":"\u043a\u0440\u0443\u0442\u043e\u0439 \u0447\u0435\u043b","visible":"1"},{"id":"2","name":"\u041f\u0435\u0442\u044f","phone":"222222","email":"petya@mail.ru","discount_fixed":"5","discount_stored":null,"total_balance":null,"comment":"\u043d\u0435 \u043c\u0435\u043d\u0435\u0435 \u043a\u0440\u0443\u0442","visible":"1"},{"id":"3","name":"\u042d\u0434\u0443\u0430\u0440\u0434","phone":"444","email":"","discount_fixed":"0","discount_stored":null,"total_balance":null,"comment":"\u0442\u0430\u043a\u043e\u0439 \u0441\u0435\u0431\u0435 \u0447\u0435\u043b","visible":"1"}]}',
            
        ),
        
        "user_add" => array(
            
            "name" => "Пользователи. Add",
            
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
                
                "action" => array(
                    "value" => "add",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае добавление (add). Обязательное поле."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Имя пользователя. Обязательное поле."
                ),
                
                "phone" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Телефон пользователя."
                ),
                
                "email" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "E-mail сотрудника."
                ),
                
                "discount_fixed" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "Фиксированая скидка."
                ),
                
                "comment" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Комментарий."
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "user/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"add","name":"Иван"}',
                    "test_file" => "user_add.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        "user_edit" => array(
            
            "name" => "Пользователи. Edit",
            
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
                
                "action" => array(
                    "value" => "edit",
                    "type"  => "string", 
                    "descr" => "Совершаемое действие, в данном случае редактирование (edit). Обязательное поле."
                ),
                
                "id" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID редактируемого пользователя. Обязательное поле."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Имя пользователя."
                ),
                
                "phone" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Телефон пользователя."
                ),
                
                "email" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "E-mail сотрудника."
                ),
                
                "discount_fixed" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "Фиксированая скидка."
                ),
                
                "comment" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Комментарий."
                ),
                
                "visible" => array(
                    "value" => "0 или 1 ",
                    "type"  => "flag", 
                    "descr" => "Видимость сотрудника."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "user/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"edit","name":"Андрей","visible":"1"}',
                    "test_file" => "user_edit.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
    
        /*
        
        
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
                
                "insert"    => array( "code" => 31,     "status_code" => 400,   "message" => "Insert object error" ),
            
                "sid"       => array( "code" => 50,     "status_code" => 401,   "message" => "Wrong user sid" ),
                "perm"      => array( "code" => 51,     "status_code" => 403,   "message" => "You do not have permission for this action" ),
                
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