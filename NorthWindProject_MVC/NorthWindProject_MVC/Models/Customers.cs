using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace NorthWindProject_MVC.Models;

public partial class Customers
{
    [Key]
    [Display(Name = "客戶ID")]
    public string CustomerId { get; set; } = null!;

    [Display(Name = "公司名稱")]
    public string CompanyName { get; set; } = null!;
    
    [Display(Name = "聯絡姓名")]
    public string? ContactName { get; set; }

    [Display(Name = "聯絡人職務")]
    public string? ContactTitle { get; set; }

    [Display(Name = "地址")]
    public string? Address { get; set; }

    [Display(Name = "居住城市")]
    public string? City { get; set; }

    [Display(Name = "地區")]
    public string? Region { get; set; }

    [Display(Name = "區碼")]
    public string? PostalCode { get; set; }

    [Display(Name = "國家")]
    public string? Country { get; set; }

    [Display(Name = "電話")]
    public string? Phone { get; set; }

    [Display(Name = "傳真")]
    public string? Fax { get; set; }


}
