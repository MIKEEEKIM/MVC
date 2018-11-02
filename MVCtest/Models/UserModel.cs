using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCtest.Models
{
    public class UserModel
    {

        public int UserID { get; set; }                 //用户编号
        public string UserName { get; set; }            //用户名
        public string Password { get; set; }            //密码     
        public int Age { get; set; }                    //年龄
        public int Political { get; set; }              //政治面貌
        public int Height { get; set; }                 //身高       
        public DateTime GraduatedDate { get; set; }    //毕业日期
        public string Address { get; set; }             //现住地址
        public string Phone { get; set; }               //联系电话
        public string ImagePath { get; set; }           //头相地址
        public string Other { get; set; }               //其他描述





    }




    public class LoginMod    {
        public string UserName { get; set; }            //用户名
        public string Password { get; set; }            //密码
    }

   public class RegeditModel
    {           public string UserName { get; set; }            //用户名
                public string Password { get; set; }            //密码
                public int Sex { get; set; }                    //性别
                public int Age { get; set; }                    //年龄
     }












}



