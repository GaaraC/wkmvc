//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_USER
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string ACCOUNT { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<int> ISLOCK { get; set; }
        public Nullable<int> DEPSORT { get; set; }
        public Nullable<int> COMPANYSORT { get; set; }
        public string FACEIMG { get; set; }
        public string LEVELS { get; set; }
        public string DEPID { get; set; }
        public string CREATEUSER { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string UPDATEUSER { get; set; }
        public Nullable<System.DateTime> UPDATEDATE { get; set; }
        public string LASTLOGIP { get; set; }
    }
}
