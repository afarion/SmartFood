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
            
            "name" => "Тип расходника. View",
            
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
            
            "name" => "Тип расходника. Add",
            
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
            
            "name" => "Тип расходника. Edit",
            
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
            
            "name" => "Категория расходника. View",
            
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
            
            "name" => "Категория расходника. Add",
            
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
            
            "name" => "Категория расходника. Edit",
            
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
            
            "name" => "Расходники. View",
            
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
                                &#8226; type - название типа расходника<br />
                                &#8226; category - название категории расходника<br />
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
            
            "response" => '{"count":7,"items":[{"id":"1","name":"\u0424\u043e\u0440\u0435\u043b\u044c","id_type":"1","id_category":"1","id_unit":"1","amount":"2.500","price":"2.04","waste_pct":"40","visible":"1","type":"\u041f\u0440\u043e\u0434\u0443\u043a\u0442","category":"\u0420\u044b\u0431\u0430","unit":"\u0448\u0442."},{"id":"5","name":"\u041a\u0430\u0440\u0442\u043e\u0448\u043a\u0430","id_type":"1","id_category":"2","id_unit":"1","amount":"0.000","price":"0.00","waste_pct":"17","visible":"1","type":"\u041f\u0440\u043e\u0434\u0443\u043a\u0442","category":"\u041e\u0432\u043e\u0449\u0438","unit":"\u0448\u0442."},{"id":"6","name":"\u0413\u043e\u0432\u044f\u0434\u0438\u043d\u0430","id_type":"1","id_category":"3","id_unit":"1","amount":"1.000","price":"0.00","waste_pct":"0","visible":"1","type":"\u041f\u0440\u043e\u0434\u0443\u043a\u0442","category":"\u041c\u044f\u0441\u043e","unit":"\u0448\u0442."},{"id":"8","name":"\u041c\u043e\u0440\u043a\u043e\u0432\u043a\u0430","id_type":"1","id_category":"2","id_unit":"1","amount":"1.800","price":"0.00","waste_pct":"0","visible":"1","type":"\u041f\u0440\u043e\u0434\u0443\u043a\u0442","category":"\u041e\u0432\u043e\u0449\u0438","unit":"\u0448\u0442."},{"id":"9","name":"\u041c\u044b\u043b\u043e","id_type":"3","id_category":"8","id_unit":"1","amount":"1.561","price":"0.00","waste_pct":"36","visible":"1","type":"\u0411\u044b\u0442\u043e\u0432\u0430\u044f \u0445\u0438\u043c\u0438\u044f","category":"\u041c\u044b\u043b\u043e","unit":"\u0448\u0442."},{"id":"10","name":"\u0421\u0432\u0438\u043d\u0438\u043d\u0430","id_type":"1","id_category":"3","id_unit":"2","amount":"0.000","price":"100.00","waste_pct":"0","visible":"1","type":"\u041f\u0440\u043e\u0434\u0443\u043a\u0442","category":"\u041c\u044f\u0441\u043e","unit":"\u043a\u0433."},{"id":"11","name":"\u0441\u0430\u043b\u0444\u0435\u0442\u043a\u0438 \u0440\u0443\u0442\u0430","id_type":"2","id_category":"5","id_unit":"6","amount":"0.000","price":"1.00","waste_pct":"0","visible":"1","type":"\u0420\u0430\u0441\u0445\u043e\u0434\u043d\u0438\u043a\u0438","category":"\u0421\u0430\u043b\u0444\u0435\u0442\u043a\u0438","unit":"\u0443\u043f."}]}',
            
        ),
        
        "item_add" => array(
            
            "name" => "Расходники. Add",
            
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
                    "descr" => "Название расходника. Обязательное поле."
                ),
                
                "id_type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID типа расходника. Обязательное поле."
                ),
                
                "id_category" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID категории расходника. Обязательное поле."
                ),
                
                "id_unit" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID единицы измерения расходника. Обязательное поле."
                ),
                
                /*
                "amount" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Колличество на складе."
                ),
                */
                
                "waste_pct" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "Процент отхода расходника."
                ),
                
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
            
            "name" => "Расходники. Edit",
            
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
                    "descr" => "ID редактируемого расходника. Обязательное поле."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Название расходника."
                ),
                
                "id_type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID типа расходника."
                ),
                
                "id_category" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID категории расходника."
                ),
                
                "id_unit" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID единицы измерения расходника."
                ),
                
                "waste_pct" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "Процент отхода расходника."
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
                    "descr" => "Видимость расходника."
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
            
            "response" => '{"count":3,"items":[{"id":"1","name":"\u041f\u043e\u0441\u0442\u0430\u0432\u0449\u0438\u043a \u043f\u0435\u0440\u0432\u044b\u0439","phone":"","email":"","skype":"","notes":"\u041e\u043d \u043f\u0435\u0440\u0432\u044b\u0439!","visible":"1"},{"id":"2","name":"\u041f\u043e\u0441\u0442\u0430\u0432\u0449\u0438\u043a 2","phone":"","email":"","skype":"","notes":"\u0434\u043e\u043b\u0436\u0435\u043d \u0434\u0435\u043d\u0435\u0433","visible":"1"},{"id":"3","name":"\u041f\u043e\u0441\u0442\u0430\u0432\u0449\u0438\u043a 3","phone":"","email":"","skype":"","notes":"","visible":"1"}]}',
            
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
                
                "phone" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Телефон поставщика."
                ),
                
                "email" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "E-mail поставщика."
                ),
                
                "skype" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Skype поставщика."
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
                
                "phone" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Телефон поставщика."
                ),
                
                "email" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "E-mail поставщика."
                ),
                
                "skype" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Skype поставщика."
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
            
            "name" => "Клиенты. View",
            
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
            
            "name" => "Клиенты. Add",
            
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
                
                "discount_reason" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Причина скидки."
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
            
            "name" => "Клиенты. Edit",
            
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
                
                "discount_reason" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Причина скидки."
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
        
        // ====================================================================================================
        // USER ADDRESS
        
        "useraddress_view" => array(
            
            "name" => "Адреса клиентов. View",
            
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
                
                "user" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID пользователя."
                ),
                
                "order" => array(
                    "value" => "[priority|name|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />priority - по приоритету<br />name - по названию<br />create - по дате создания" 
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "useraddress/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view","user":"1"}',
                    "test_file" => "useraddress_view.php"
                ),
            
            "response" => '{"count":3,"items":[{"id":"3","address":"\u0411\u043e\u043b\u044c\u0448\u0430\u044f \u0410\u0440\u043d\u0430\u0443\u0442\u0441\u043a\u0430\u044f, 72\/74"},{"id":"1","address":"\u0414\u0435\u0440\u0438\u0431\u0430\u0441\u043e\u0432\u0441\u043a\u0430\u044f, 1"},{"id":"2","address":"\u041a\u043e\u0441\u043c\u043e\u043d\u0430\u0432\u0442\u043e\u0432, 10"}]}',
            
        ),
        
        "useraddress_add" => array(
            
            "name" => "Адреса клиентов. Add",
            
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
                
                "id_user" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID пользователя. Обязательное поле."
                ),
                
                "address" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Адрес пользователя. Обязательное поле."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "useraddress/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"add","id_user":"1","address":"Адрес"}',
                    "test_file" => "useraddress_add.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        // ====================================================================================================
        // ADMIN
        
        "admin_view" => array(
            
            "name" => "Аккаунты. View",
            
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
                    "link" => "admin/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view"}',
                    "test_file" => "admin_view.php"
                ),
            
            "response" => '{"count":4,"items":[{"id":"1","id_type":"1","id_employee":"1","login":"admin","visible":"1"},{"id":"2","id_type":"2","id_employee":"1","login":"admin","visible":"1"},{"id":"3","id_type":"3","id_employee":"1","login":"admin","visible":"1"},{"id":"4","id_type":"1","id_employee":"2","login":"vadim","visible":"1"}]}',
            
        ),
        
        "admin_add" => array(
            
            "name" => "Аккаунты. Add",
            
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
                    "descr" => "ID типа аккаунта. Обязательное поле."
                ),
                
                "id_employee" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID сотрудника. Обязательное поле."
                ),
                
                "login" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Логин. Используется при аутентификации. Обязательное поле."
                ),
                
                "pass" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Пароль. Используется при аутентификации. Обязательное поле."
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "admin/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"add","id_type":"1","id_employee":"1","login":"new_admin","pass":"12345"}',
                    "test_file" => "admin_add.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        "admin_edit" => array(
            
            "name" => "Аккаунты. Edit",
            
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
                    "descr" => "ID редактируемого аккаунта. Обязательное поле."
                ),
                
                "id_type" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID типа аккаунта."
                ),
                
                "id_employee" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID сотрудника."
                ),
                
                "login" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Логин. Используется при аутентификации."
                ),
                
                "pass" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Пароль. Используется при аутентификации."
                ),
                
                "visible" => array(
                    "value" => "0 или 1 ",
                    "type"  => "flag", 
                    "descr" => "Видимость аккаунта."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "admin/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"edit","pass":"11111","visible":"1"}',
                    "test_file" => "admin_edit.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        // ====================================================================================================
        // PURCHASE
        
        "purchase_view" => array(
            
            "name" => "Приход. View",
            
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
                    "value" => "[create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />create - по дате создания" 
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "purchase/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view"}',
                    "test_file" => "purchase_view.php"
                ),
            
            "response" => '{"count":2,"items":[{"id":"1","id_item":"1","id_provider":"2","id_admin":"4","id_employee":"4","amount":"10.000","price":"12.90","date_create":"2016-12-07 22:48:38"},{"id":"2","id_item":"1","id_provider":"2","id_admin":"4","id_employee":"4","amount":"25.000","price":"51.00","date_create":"2016-12-07 22:49:24"}]}',
            
        ),
        
        "purchase_add" => array(
            
            "name" => "Приход. Add",
            
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
                
                "id_item" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID расходника. Обязательное поле."
                ),
                
                "id_provider" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID поставщика. Обязательное поле."
                ),
                
                "id_employee" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID сотрудника. Обязательное поле."
                ),
                
                "amount" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Колличество / вес прихода. Обязательное поле."
                ),
                
                "price" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Общая цена прихода. Обязательное поле."
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "purchase/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"add","id_item":"1","id_provider":"1","id_employee":"1","amount":"100","price":"235.50"}',
                    "test_file" => "purchase_add.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        // ====================================================================================================
        // OUTLAY
        
        "outlay_view" => array(
            
            "name" => "Списание. View",
            
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
                    "value" => "[create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />create - по дате создания" 
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "outlay/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view"}',
                    "test_file" => "outlay_view.php"
                ),
            
            "response" => '{"count":3,"items":[{"id":"1","id_item":"1","id_admin":"4","id_employee":"4","amount":"20.000","waste":"0.000","comment":"\u0438\u0441\u043f\u043e\u0440\u0442\u0438\u043b\u0430\u0441\u044c \u0444\u043e\u0440\u0435\u043b\u044c","date_create":"2016-12-08 22:10:42"},{"id":"3","id_item":"1","id_admin":"4","id_employee":"4","amount":"11.500","waste":"0.000","comment":"\u0438\u0441\u043f\u043e\u0440\u0442\u0438\u043b\u0430\u0441\u044c \u0444\u043e\u0440\u0435\u043b\u044c","date_create":"2016-12-08 22:11:14"},{"id":"5","id_item":"1","id_admin":"4","id_employee":"4","amount":"1.000","waste":"0.000","comment":"\u043e\u043f\u044f\u0442\u044c \u0438\u0441\u043f\u043e\u0440\u0442\u0438\u043b\u0430\u0441\u044c","date_create":"2016-12-08 22:13:41"}]}',
            
        ),
        
        "outlay_add" => array(
            
            "name" => "Списание. Add",
            
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
                
                "id_item" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID расходника. Обязательное поле."
                ),
                
                "id_employee" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID сотрудника. Обязательное поле."
                ),
                
                "amount" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Колличество / вес прихода. Обязательное поле."
                ),
                
                "comment" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Комментарий."
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "outlay/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"add","id_item":"1","id_employee":"1","amount":"100","comment":"причина списания"}',
                    "test_file" => "outlay_add.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        // ====================================================================================================
        // DISH CATEGORY
    
        "dishcategory" => array(
            
            "name" => "Категории товаров. View",
            
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
                    "link" => "dishcategory/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view","order":"priority"}',
                    "test_file" => "dishcategory_view.php"
                ),
            
            "response" => '{"count":12,"items":[{"id":"1","name":"\u0421\u0443\u0448\u0438 - \u041d\u0438\u0433\u0438\u0440\u0438\/\u0413\u0443\u043d\u043a\u0430\u043d\u044b"},{"id":"2","name":"\u0421\u0443\u0448\u0438 - \u0420\u043e\u043b\u043b\u044b"},{"id":"3","name":"\u0421\u0443\u0448\u0438 - \u0413\u043e\u0440\u044f\u0447\u0438\u0435 \u0440\u043e\u043b\u043b\u044b"},{"id":"4","name":"\u0421\u0443\u0448\u0438 - \u0421\u043e\u0448\u0438\u043c\u0438"},{"id":"5","name":"\u0421\u0443\u0448\u0438 - \u0421\u0435\u0442\u044b"},{"id":"6","name":"\u041f\u0438\u0446\u0446\u0430"},{"id":"7","name":"BBQ - \u0411\u0443\u0440\u0433\u0435\u0440\u044b"},{"id":"8","name":"BBQ - \u0413\u0430\u0440\u043d\u0438\u0440\u044b"},{"id":"9","name":"BBQ - \u0421\u0442\u0435\u0439\u043a\u0438"},{"id":"10","name":"\u0421\u0430\u043b\u0430\u0442\u044b"},{"id":"11","name":"\u0414\u0435\u0441\u0435\u0440\u0442\u044b"},{"id":"12","name":"\u041d\u0430\u043f\u0438\u0442\u043a\u0438"}]}',
            
        ),
        
        // ====================================================================================================
        // DISH
        
        "dish_view" => array(
            
            "name" => "Товары. View",
            
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
                    "value" => "[category]",
                    "type"  => "string", 
                    "descr" => "Дополнительные поля, перечисленые через запятую. Если указаны, будут добавлены в ответ.<br />
                                &#8226; category - название категории товара" 
                ),
                
                "category" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID категории. Если указан, будут возвращены объекты только этой категории."
                ),
                
                "order" => array(
                    "value" => "[priority|name|price|price_desc|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />
                                &#8226; priority - по приоритету<br />
                                &#8226; name - по названию<br />
                                &#8226; price - по возрастанию цены<br />
                                &#8226; price_desc - по убыванию цены<br />
                                &#8226; create - по дате создания" 
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "dish/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view","part":"category","order":"priority"}',
                    "test_file" => "dish_view.php"
                ),
            
            "response" => '{"count":2,"items":[{"id":"1","id_category":"1","name":"\u0411\u0443\u0440\u0433\u0435\u0440 1","weight":"250.000","price":"120.00","visible":"1","category":"\u0421\u0443\u0448\u0438 - \u041d\u0438\u0433\u0438\u0440\u0438\/\u0413\u0443\u043d\u043a\u0430\u043d\u044b"},{"id":"2","id_category":"1","name":"\u0411\u0443\u0440\u0433\u0435\u0440 \u0432\u0442\u043e\u0440\u043e\u0439","weight":"230.000","price":"135.00","visible":"1","category":"\u0421\u0443\u0448\u0438 - \u041d\u0438\u0433\u0438\u0440\u0438\/\u0413\u0443\u043d\u043a\u0430\u043d\u044b"}]}',
            
        ),
        
        "dish_add" => array(
            
            "name" => "Товары. Add",
            
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
                
                "id_category" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID категории товара. Обязательное поле."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Название товара. Обязательное поле."
                ),
                
                "weight" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Вес товара."
                ),
                
                "price" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Цена товара."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "dish/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"add","name":"Бургер","id_category":"1","weight":"200","price":"52"}',
                    "test_file" => "dish_add.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        "dish_edit" => array(
            
            "name" => "Товары. Edit",
            
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
                    "descr" => "ID редактируемого товара. Обязательное поле."
                ),
                
                "id_category" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID категории товара."
                ),
                
                "name" => array(
                    "value" => "",
                    "type"  => "string", 
                    "descr" => "Название товара."
                ),

                "weight" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Вес товара."
                ),
                
                "price" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Цена товара."
                ),
                
                "visible" => array(
                    "value" => "0 или 1 ",
                    "type"  => "flag", 
                    "descr" => "Видимость товара."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "dish/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"edit","id":"1","name":"Бургер","id_category":"1"}',
                    "test_file" => "dish_edit.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        // ====================================================================================================
        // DISH ITEM
        
        "dishitem_view" => array(
            
            "name" => "Расходники товаров. View",
            
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
                    "value" => "[item]",
                    "type"  => "string", 
                    "descr" => "Дополнительные поля, перечисленые через запятую. Если указаны, будут добавлены в ответ.<br />
                                &#8226; item - название расходника" 
                ),
                
                "dish" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID товара. Если указан, будут возвращены объекты только этого товара."
                ),
                
                "order" => array(
                    "value" => "[priority|name|create]",
                    "type"  => "string", 
                    "descr" => "Сортировка результатов. Варианты сортировок:<br />
                                &#8226; priority - по приоритету<br />
                                &#8226; name - по названию<br />
                                &#8226; create - по дате создания" 
                ),
                
            ),
            
            "request_post" => 
                array(
                    "link" => "dishitem/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"view","part":"item","order":"priority"}',
                    "test_file" => "dishitem_view.php"
                ),
            
            "response" => '{"count":3,"items":[{"id":"1","id_dish":"1","id_item":"5","weight":"80.000","visible":"1","item":"\u041a\u0430\u0440\u0442\u043e\u0448\u043a\u0430"},{"id":"2","id_dish":"1","id_item":"6","weight":"100.000","visible":"1","item":"\u0413\u043e\u0432\u044f\u0434\u0438\u043d\u0430"},{"id":"3","id_dish":"1","id_item":"8","weight":"20.000","visible":"1","item":"\u041c\u043e\u0440\u043a\u043e\u0432\u043a\u0430"}]}',
            
        ),
        
        "dishitem_add" => array(
            
            "name" => "Расходники товаров. Add",
            
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
                
                "id_dish" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID товара. Обязательное поле."
                ),
                
                "id_item" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID расходника. Обязательное поле."
                ),
                
                "weight" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Вес расходника."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "dishitem/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"add","id_dish":"1","id_item":"1","weight":"200"}',
                    "test_file" => "dishitem_add.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        "dishitem_edit" => array(
            
            "name" => "Расходники товаров. Edit",
            
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
                    "descr" => "ID редактируемого расходника. Обязательное поле."
                ),
                
                "id_dish" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID товара."
                ),
                
                "id_item" => array(
                    "value" => "",
                    "type"  => "int", 
                    "descr" => "ID расходника."
                ),
                
                "weight" => array(
                    "value" => "",
                    "type"  => "float", 
                    "descr" => "Вес расходника."
                ),
                
                "visible" => array(
                    "value" => "0 или 1 ",
                    "type"  => "flag", 
                    "descr" => "Видимость расходника."
                ),
            ),
            
            "request_post" => 
                array(
                    "link" => "dishitem/",
                    "params" => '{"user_id":"1","user_type":"1","user_sid":"9a3ef3a7cc8e17d613c7e43b87b5433d5da8ccb9","action":"edit","id":"1","weight":"150"}',
                    "test_file" => "dishitem_edit.php"
                ),
            
            "response" => '{"success":1}',
            
        ),
        
        
        
        
        // ====================================================================================================
        // ERRORS
        
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