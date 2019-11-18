using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.product{
	
	
	
	
	
	public class Attribute {
		
		///<summary>
		/// attribute id
		///</summary>
		
		private string attrId_;
		
		///<summary>
		/// attribute value
		///</summary>
		
		private string attrValue_;
		
		///<summary>
		/// attribute description
		///</summary>
		
		private string attrDesc_;
		
		public string GetAttrId(){
			return this.attrId_;
		}
		
		public void SetAttrId(string value){
			this.attrId_ = value;
		}
		public string GetAttrValue(){
			return this.attrValue_;
		}
		
		public void SetAttrValue(string value){
			this.attrValue_ = value;
		}
		public string GetAttrDesc(){
			return this.attrDesc_;
		}
		
		public void SetAttrDesc(string value){
			this.attrDesc_ = value;
		}
		
	}
	
}