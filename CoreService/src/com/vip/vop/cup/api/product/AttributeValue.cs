using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class AttributeValue {
		
		///<summary>
		/// 选项ID
		///</summary>
		
		private int? option_id_;
		
		///<summary>
		/// 选项名称
		///</summary>
		
		private string option_name_;
		
		///<summary>
		/// 选项别名
		///</summary>
		
		private string option_aliases_;
		
		///<summary>
		/// 属性值（文本/数值/布尔）
		///</summary>
		
		private string literal_;
		
		///<summary>
		/// 属性值解析是否成功标识。0：失败，1：成功
		///</summary>
		
		private byte? flag_;
		
		///<summary>
		/// 排序因子
		///</summary>
		
		private int? sort_;
		
		public int? GetOption_id(){
			return this.option_id_;
		}
		
		public void SetOption_id(int? value){
			this.option_id_ = value;
		}
		public string GetOption_name(){
			return this.option_name_;
		}
		
		public void SetOption_name(string value){
			this.option_name_ = value;
		}
		public string GetOption_aliases(){
			return this.option_aliases_;
		}
		
		public void SetOption_aliases(string value){
			this.option_aliases_ = value;
		}
		public string GetLiteral(){
			return this.literal_;
		}
		
		public void SetLiteral(string value){
			this.literal_ = value;
		}
		public byte? GetFlag(){
			return this.flag_;
		}
		
		public void SetFlag(byte? value){
			this.flag_ = value;
		}
		public int? GetSort(){
			return this.sort_;
		}
		
		public void SetSort(int? value){
			this.sort_ = value;
		}
		
	}
	
}