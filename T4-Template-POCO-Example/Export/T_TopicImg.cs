using System;
using NPoco;
using System.ComponentModel.DataAnnotations;

namespace Electric.Domain.Entities 
{
    /// <summary>
    /// Represents a T_TopicImg.
    /// NOTE: 这个类是从T4模板生成的——你不应该手动修改它。
    /// </summary>
	[MetadataType(typeof(TopicImgMetadata))]
	[PrimaryKey("Id")]
	[TableName("[dbo].[T_TopicImg]")]
    public class T_TopicImg 
    {
	    #region ResultColumn
        #endregion
        #region Ignore
        #endregion
		
		private class TopicImgMetadata{
			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Id")]
			public int Id { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("Url")]
			public string Url { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否是图片 0否1是")]
			[Column("IsImg")]
			public bool IsImg { get; set; }

			[StringLength(1, ErrorMessage = "{0}不能超过1个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "是否视屏0否1是")]
			[Column("IsVideo")]
			public bool IsVideo { get; set; }

			[StringLength(8, ErrorMessage = "{0}不能超过8个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "")]
			[Column("CreateTime")]
			public DateTime CreateTime { get; set; }

			[StringLength(4, ErrorMessage = "{0}不能超过4个字符！")]
			[Required(ErrorMessage = "请填写{0}！")]
			[Display(Name = "话题id")]
			[Column("DynamicID")]
			public int DynamicID { get; set; }

			[StringLength(255, ErrorMessage = "{0}不能超过255个字符！")]
			
			[Display(Name = "")]
			[Column("Poster")]
			public string Poster { get; set; }

			
			
			[Display(Name = "")]
			[Column("VideoSize")]
			public int? VideoSize { get; set; }

			[StringLength(50, ErrorMessage = "{0}不能超过50个字符！")]
			
			[Display(Name = "")]
			[Column("Duration")]
			public string Duration { get; set; }

    }
  }      
}
