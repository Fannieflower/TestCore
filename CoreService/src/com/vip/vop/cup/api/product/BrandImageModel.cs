using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.product{
	
	
	
	
	
	public class BrandImageModel {
		
		///<summary>
		/// 品牌图片ID
		///</summary>
		
		private int? id_;
		
		///<summary>
		/// 品牌ID
		///</summary>
		
		private string brand_id_;
		
		///<summary>
		/// 图号
		///</summary>
		
		private int? image_index_;
		
		///<summary>
		/// 图片地址（无图片域名，使用时需拼接图片域名）新增修改品牌时图片URL不能带有域名
		///</summary>
		
		private string image_url_;
		
		public int? GetId(){
			return this.id_;
		}
		
		public void SetId(int? value){
			this.id_ = value;
		}
		public string GetBrand_id(){
			return this.brand_id_;
		}
		
		public void SetBrand_id(string value){
			this.brand_id_ = value;
		}
		public int? GetImage_index(){
			return this.image_index_;
		}
		
		public void SetImage_index(int? value){
			this.image_index_ = value;
		}
		public string GetImage_url(){
			return this.image_url_;
		}
		
		public void SetImage_url(string value){
			this.image_url_ = value;
		}
		
	}
	
}