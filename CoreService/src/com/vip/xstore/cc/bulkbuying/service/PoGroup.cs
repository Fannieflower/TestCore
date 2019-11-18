using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	
	
	public class PoGroup {
		
		///<summary>
		/// 采购数量
		///</summary>
		
		private int? purchaseQuantity_;
		
		///<summary>
		/// 采购平均金额
		///</summary>
		
		private double? avgAmount_;
		
		///<summary>
		/// 采购总金额
		///</summary>
		
		private double? totalAmount_;
		
		///<summary>
		/// 折扣（0~1）
		///</summary>
		
		private double? discount_;
		
		///<summary>
		/// 品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 品牌编码
		///</summary>
		
		private string brandSn_;
		
		///<summary>
		/// 二级分类ID
		///</summary>
		
		private string seasonName_;
		
		///<summary>
		/// 二级分类ID
		///</summary>
		
		private string subCategoryId_;
		
		///<summary>
		/// 二级分类名称
		///</summary>
		
		private string subCategoryName_;
		
		///<summary>
		/// 三级分类ID
		///</summary>
		
		private string leafCategoryId_;
		
		///<summary>
		/// 三级分类名称
		///</summary>
		
		private string leafCategoryName_;
		
		///<summary>
		/// 季节
		///</summary>
		
		private string season_;
		
		public int? GetPurchaseQuantity(){
			return this.purchaseQuantity_;
		}
		
		public void SetPurchaseQuantity(int? value){
			this.purchaseQuantity_ = value;
		}
		public double? GetAvgAmount(){
			return this.avgAmount_;
		}
		
		public void SetAvgAmount(double? value){
			this.avgAmount_ = value;
		}
		public double? GetTotalAmount(){
			return this.totalAmount_;
		}
		
		public void SetTotalAmount(double? value){
			this.totalAmount_ = value;
		}
		public double? GetDiscount(){
			return this.discount_;
		}
		
		public void SetDiscount(double? value){
			this.discount_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetBrandSn(){
			return this.brandSn_;
		}
		
		public void SetBrandSn(string value){
			this.brandSn_ = value;
		}
		public string GetSeasonName(){
			return this.seasonName_;
		}
		
		public void SetSeasonName(string value){
			this.seasonName_ = value;
		}
		public string GetSubCategoryId(){
			return this.subCategoryId_;
		}
		
		public void SetSubCategoryId(string value){
			this.subCategoryId_ = value;
		}
		public string GetSubCategoryName(){
			return this.subCategoryName_;
		}
		
		public void SetSubCategoryName(string value){
			this.subCategoryName_ = value;
		}
		public string GetLeafCategoryId(){
			return this.leafCategoryId_;
		}
		
		public void SetLeafCategoryId(string value){
			this.leafCategoryId_ = value;
		}
		public string GetLeafCategoryName(){
			return this.leafCategoryName_;
		}
		
		public void SetLeafCategoryName(string value){
			this.leafCategoryName_ = value;
		}
		public string GetSeason(){
			return this.season_;
		}
		
		public void SetSeason(string value){
			this.season_ = value;
		}
		
	}
	
}