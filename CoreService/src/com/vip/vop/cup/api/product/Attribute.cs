using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class Attribute {
		
		///<summary>
		/// 属性Id
		///</summary>
		
		private int? attribute_id_;
		
		///<summary>
		/// 属性名称
		///</summary>
		
		private string attribute_name_;
		
		///<summary>
		/// 外文名称, 保存格式为JSON
		///</summary>
		
		private string foreign_name_;
		
		///<summary>
		/// 属性类型：商品属性/标签属性
		///</summary>
		
		private com.vip.vop.cup.api.product.AttributeType? type_;
		
		///<summary>
		/// 数据类型：文本/数值/选项/布尔
		///</summary>
		
		private com.vip.vop.cup.api.product.DataType? data_type_;
		
		///<summary>
		/// 属性解析是否成功标识，0=失败，1=成功
		///</summary>
		
		private byte? flag_;
		
		///<summary>
		/// 属性值列表
		///</summary>
		
		private List<com.vip.vop.cup.api.product.AttributeValue> values_;
		
		public int? GetAttribute_id(){
			return this.attribute_id_;
		}
		
		public void SetAttribute_id(int? value){
			this.attribute_id_ = value;
		}
		public string GetAttribute_name(){
			return this.attribute_name_;
		}
		
		public void SetAttribute_name(string value){
			this.attribute_name_ = value;
		}
		public string GetForeign_name(){
			return this.foreign_name_;
		}
		
		public void SetForeign_name(string value){
			this.foreign_name_ = value;
		}
		public com.vip.vop.cup.api.product.AttributeType? GetType(){
			return this.type_;
		}
		
		public void SetType(com.vip.vop.cup.api.product.AttributeType? value){
			this.type_ = value;
		}
		public com.vip.vop.cup.api.product.DataType? GetData_type(){
			return this.data_type_;
		}
		
		public void SetData_type(com.vip.vop.cup.api.product.DataType? value){
			this.data_type_ = value;
		}
		public byte? GetFlag(){
			return this.flag_;
		}
		
		public void SetFlag(byte? value){
			this.flag_ = value;
		}
		public List<com.vip.vop.cup.api.product.AttributeValue> GetValues(){
			return this.values_;
		}
		
		public void SetValues(List<com.vip.vop.cup.api.product.AttributeValue> value){
			this.values_ = value;
		}
		
	}
	
}