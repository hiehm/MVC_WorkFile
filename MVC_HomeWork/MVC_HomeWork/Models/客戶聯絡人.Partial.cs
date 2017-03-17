namespace MVC_HomeWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人 : IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var obj = RepositoryHelper.Get客戶聯絡人Repository();
            if (obj.CheckEmail(this.客戶Id, this.Email))
            {
                yield return new ValidationResult("信箱重複");
                yield break;
            }            
        }
    }

    public partial class 客戶聯絡人MetaData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 職稱 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 姓名 { get; set; }
        
        [StringLength(250, ErrorMessage="欄位長度不得大於 250 個字元")]
        [Required]
        [EmailAddress(ErrorMessage ="請輸入信箱格式")]
        public string Email { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [RegularExpression("^(0)(9)([0-9]{8})$", ErrorMessage = "行動電話格式不正確")]
        public string 手機 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Phone(ErrorMessage ="請輸入手機號碼")]
        public string 電話 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }

 
    }
}
