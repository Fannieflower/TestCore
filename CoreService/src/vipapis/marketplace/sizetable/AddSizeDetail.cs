using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.sizetable{
	
	
	
	
	
	public class AddSizeDetail {
		
		///<summary>
		/// 尺码表详情名称
		///</summary>
		
		private string size_detail_name_;
		
		///<summary>
		/// 属性值
		/// @sampleValue size_detail_properties 袖长：35，肩宽：36
		///</summary>
		
		private Dictionary<string, string> size_detail_properties_;
		
		///<summary>
		/// 尺码表详情序号，默认从0开始排序，传入此字段可进行尺码表详情的排序
		///</summary>
		
		private int? size_detail_order_;
		
		public string GetSize_detail_name(){
			return this.size_detail_name_;
		}
		
		public void SetSize_detail_name(string value){
			this.size_detail_name_ = value;
		}
		public Dictionary<string, string> GetSize_detail_properties(){
			return this.size_detail_properties_;
		}
		
		public void SetSize_detail_properties(Dictionary<string, string> value){
			this.size_detail_properties_ = value;
		}
		public int? GetSize_detail_order(){
			return this.size_detail_order_;
		}
		
		public void SetSize_detail_order(int? value){
			this.size_detail_order_ = value;
		}
		
	}
	
}