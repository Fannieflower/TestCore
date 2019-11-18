using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.product.pool.service{
	
	
	
	
	
	public class ProdPoolSkuModel {
		
		///<summary>
		/// po单号
		///</summary>
		
		private string poNo_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 残次等级
		///</summary>
		
		private string grade_;
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string warehouseCode_;
		
		///<summary>
		/// 库存数量
		///</summary>
		
		private long? availableStock_;
		
		///<summary>
		/// 款号
		///</summary>
		
		private string osn_;
		
		///<summary>
		/// 货号
		///</summary>
		
		private string sn_;
		
		///<summary>
		/// 库龄
		///</summary>
		
		private int? age_;
		
		///<summary>
		/// 商品库sku_id
		///</summary>
		
		private string vSkuId_;
		
		///<summary>
		/// 商品库spu_id
		///</summary>
		
		private string vSpuId_;
		
		///<summary>
		/// 吊牌价
		///</summary>
		
		private double? marketPrice_;
		
		///<summary>
		/// vip售卖价
		///</summary>
		
		private double? basePrice_;
		
		///<summary>
		/// vip到手价
		///</summary>
		
		private double? vipPayPrice_;
		
		///<summary>
		/// vip采购价
		///</summary>
		
		private double? billTaxPrice_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 图片url
		///</summary>
		
		private string mainImageUrl_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string productName_;
		
		///<summary>
		/// 尺码
		///</summary>
		
		private string size_;
		
		///<summary>
		/// 颜色
		///</summary>
		
		private string color_;
		
		///<summary>
		/// 品牌编码
		///</summary>
		
		private string brandSn_;
		
		///<summary>
		/// 品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 一级分类id
		///</summary>
		
		private string topCategoryId_;
		
		///<summary>
		/// 一级分类名称
		///</summary>
		
		private string topCategoryName_;
		
		///<summary>
		/// 二级分类id
		///</summary>
		
		private string subCategoryId_;
		
		///<summary>
		/// 二级分类名称
		///</summary>
		
		private string subCategoryName_;
		
		///<summary>
		/// 三级分类id
		///</summary>
		
		private string categoryId_;
		
		///<summary>
		/// 三级分类名称
		///</summary>
		
		private string categoryName_;
		
		///<summary>
		/// 转ri时间
		///</summary>
		
		private System.DateTime? changeTime_;
		
		///<summary>
		/// 新零售采购价
		///</summary>
		
		private double? xstoreBillTaxPrice_;
		
		///<summary>
		/// 转ri库龄
		///</summary>
		
		private int? riAge_;
		
		///<summary>
		/// 档期编号
		///</summary>
		
		private string salesPlanNo_;
		
		///<summary>
		/// 货主
		///</summary>
		
		private byte? seller_;
		
		///<summary>
		/// 季节，可为null，值不确定，如：四季适用/冬/春,秋,冬
		///</summary>
		
		private string season_;
		
		///<summary>
		/// po入库时间，可为null，若有值，则格式化为 'yyyy-MM-dd'
		///</summary>
		
		private string poInTime_;
		
		public string GetPoNo(){
			return this.poNo_;
		}
		
		public void SetPoNo(string value){
			this.poNo_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetGrade(){
			return this.grade_;
		}
		
		public void SetGrade(string value){
			this.grade_ = value;
		}
		public string GetWarehouseCode(){
			return this.warehouseCode_;
		}
		
		public void SetWarehouseCode(string value){
			this.warehouseCode_ = value;
		}
		public long? GetAvailableStock(){
			return this.availableStock_;
		}
		
		public void SetAvailableStock(long? value){
			this.availableStock_ = value;
		}
		public string GetOsn(){
			return this.osn_;
		}
		
		public void SetOsn(string value){
			this.osn_ = value;
		}
		public string GetSn(){
			return this.sn_;
		}
		
		public void SetSn(string value){
			this.sn_ = value;
		}
		public int? GetAge(){
			return this.age_;
		}
		
		public void SetAge(int? value){
			this.age_ = value;
		}
		public string GetVSkuId(){
			return this.vSkuId_;
		}
		
		public void SetVSkuId(string value){
			this.vSkuId_ = value;
		}
		public string GetVSpuId(){
			return this.vSpuId_;
		}
		
		public void SetVSpuId(string value){
			this.vSpuId_ = value;
		}
		public double? GetMarketPrice(){
			return this.marketPrice_;
		}
		
		public void SetMarketPrice(double? value){
			this.marketPrice_ = value;
		}
		public double? GetBasePrice(){
			return this.basePrice_;
		}
		
		public void SetBasePrice(double? value){
			this.basePrice_ = value;
		}
		public double? GetVipPayPrice(){
			return this.vipPayPrice_;
		}
		
		public void SetVipPayPrice(double? value){
			this.vipPayPrice_ = value;
		}
		public double? GetBillTaxPrice(){
			return this.billTaxPrice_;
		}
		
		public void SetBillTaxPrice(double? value){
			this.billTaxPrice_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public string GetMainImageUrl(){
			return this.mainImageUrl_;
		}
		
		public void SetMainImageUrl(string value){
			this.mainImageUrl_ = value;
		}
		public string GetProductName(){
			return this.productName_;
		}
		
		public void SetProductName(string value){
			this.productName_ = value;
		}
		public string GetSize(){
			return this.size_;
		}
		
		public void SetSize(string value){
			this.size_ = value;
		}
		public string GetColor(){
			return this.color_;
		}
		
		public void SetColor(string value){
			this.color_ = value;
		}
		public string GetBrandSn(){
			return this.brandSn_;
		}
		
		public void SetBrandSn(string value){
			this.brandSn_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetTopCategoryId(){
			return this.topCategoryId_;
		}
		
		public void SetTopCategoryId(string value){
			this.topCategoryId_ = value;
		}
		public string GetTopCategoryName(){
			return this.topCategoryName_;
		}
		
		public void SetTopCategoryName(string value){
			this.topCategoryName_ = value;
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
		public string GetCategoryId(){
			return this.categoryId_;
		}
		
		public void SetCategoryId(string value){
			this.categoryId_ = value;
		}
		public string GetCategoryName(){
			return this.categoryName_;
		}
		
		public void SetCategoryName(string value){
			this.categoryName_ = value;
		}
		public System.DateTime? GetChangeTime(){
			return this.changeTime_;
		}
		
		public void SetChangeTime(System.DateTime? value){
			this.changeTime_ = value;
		}
		public double? GetXstoreBillTaxPrice(){
			return this.xstoreBillTaxPrice_;
		}
		
		public void SetXstoreBillTaxPrice(double? value){
			this.xstoreBillTaxPrice_ = value;
		}
		public int? GetRiAge(){
			return this.riAge_;
		}
		
		public void SetRiAge(int? value){
			this.riAge_ = value;
		}
		public string GetSalesPlanNo(){
			return this.salesPlanNo_;
		}
		
		public void SetSalesPlanNo(string value){
			this.salesPlanNo_ = value;
		}
		public byte? GetSeller(){
			return this.seller_;
		}
		
		public void SetSeller(byte? value){
			this.seller_ = value;
		}
		public string GetSeason(){
			return this.season_;
		}
		
		public void SetSeason(string value){
			this.season_ = value;
		}
		public string GetPoInTime(){
			return this.poInTime_;
		}
		
		public void SetPoInTime(string value){
			this.poInTime_ = value;
		}
		
	}
	
}