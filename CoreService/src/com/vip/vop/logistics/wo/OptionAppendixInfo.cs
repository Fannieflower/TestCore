using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.wo{
	
	
	
	
	
	public class OptionAppendixInfo {
		
		///<summary>
		/// ID
		/// @sampleValue id 95
		///</summary>
		
		private int? id_;
		
		///<summary>
		/// 标签名称
		/// @sampleValue name true
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 标签对应值
		/// @sampleValue value true
		///</summary>
		
		private string value_;
		
		///<summary>
		/// 值中文说明
		/// @sampleValue remark 3
		///</summary>
		
		private string remark_;
		
		public int? GetId(){
			return this.id_;
		}
		
		public void SetId(int? value){
			this.id_ = value;
		}
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		public string GetValue(){
			return this.value_;
		}
		
		public void SetValue(string value){
			this.value_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		
	}
	
}