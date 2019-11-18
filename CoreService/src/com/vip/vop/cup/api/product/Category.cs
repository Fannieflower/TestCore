using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class Category {
		
		///<summary>
		/// 品类ID
		///</summary>
		
		private string category_id_;
		
		///<summary>
		/// 品类名称
		///</summary>
		
		private string category_name_;
		
		///<summary>
		/// 子分类
		///</summary>
		
		private List<com.vip.vop.cup.api.product.Category> children_;
		
		public string GetCategory_id(){
			return this.category_id_;
		}
		
		public void SetCategory_id(string value){
			this.category_id_ = value;
		}
		public string GetCategory_name(){
			return this.category_name_;
		}
		
		public void SetCategory_name(string value){
			this.category_name_ = value;
		}
		public List<com.vip.vop.cup.api.product.Category> GetChildren(){
			return this.children_;
		}
		
		public void SetChildren(List<com.vip.vop.cup.api.product.Category> value){
			this.children_ = value;
		}
		
	}
	
}