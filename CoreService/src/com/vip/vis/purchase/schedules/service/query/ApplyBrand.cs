using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	
	
	public class ApplyBrand {
		
		///<summary>
		/// 品牌编码
		///</summary>
		
		private string brandCode_;
		
		///<summary>
		/// 品牌中文名
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 品牌英文名
		///</summary>
		
		private string brandNameEn_;
		
		public string GetBrandCode(){
			return this.brandCode_;
		}
		
		public void SetBrandCode(string value){
			this.brandCode_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetBrandNameEn(){
			return this.brandNameEn_;
		}
		
		public void SetBrandNameEn(string value){
			this.brandNameEn_ = value;
		}
		
	}
	
}