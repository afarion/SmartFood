using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartFood.Core.Constants
{
    public class Actions
    {
        public const string GET = "view";
        public const string ADD = "add";
        public const string EDIT = "edit";
        public const string REMOVE = "remove";
    }

    public class RequestFields
    {
        public const string ACTION = "action";
        public const string NAME = "name";
        public const string ID = "id";
        public const string VISIBLE = "visible";
        public const string API_URI = "ApiUri";
        public const string USER_ID = "user_id";
        public const string USER_TYPE = "user_type";
        public const string USER_SID = "user_sid";
        public const string TYPE = "type";
        public const string ID_TYPE = "id_type";
        public const string LOGIN = "login";
        public const string PASSWORD = "pass";
        public const string ID_CATEGORY = "id_category";
        public const string ID_MEASURE = "id_unit";
        public const string AMOUNT = "amount";
        public const string PRICE = "price";
        public const string WASTE = "waste_pct";
        public const string PHONE = "phone";
        public const string SKYPE = "skype";
        public const string EMEIL = "email";
        public const string NOTES = "notes";
        public const string FIRST_NAME = "first_name";
        public const string LAST_NAME = "last_name";
        public const string PHONE_EX = "phone_ex";
        public const string ADDRESS = "address";
        public const string BIRTHDAY = "birthday";
        public const string COMMENT = "comment";
        public const string ID_EMPLOYEE = "id_employee";
        public const string CLIENT = "user";
        public const string CLIENT_ID = "id_user";
        public const string DISCOUNT_FIXED = "discount_fixed";
        public const string DISCOUNT_REASONE = "discount_reason";
    }
}
