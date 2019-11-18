using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class GoodsInfo {
		
		///<summary>
		/// 商品id
		///</summary>
		
		private string goodsId_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string goodsName_;
		
		///<summary>
		/// 商品描述,字段暂不输出
		///</summary>
		
		private string goodsDesc_;
		
		///<summary>
		/// 商品落地页
		///</summary>
		
		private string destUrl_;
		
		///<summary>
		/// 商品缩略图
		///</summary>
		
		private string goodsThumbUrl_;
		
		///<summary>
		/// 商品轮播图：根据商品id查询时返回，商品列表不返回
		///</summary>
		
		private List<string> goodsCarouselPictures_;
		
		///<summary>
		/// 商品主图
		///</summary>
		
		private string goodsMainPicture_;
		
		///<summary>
		/// 商品三级分类id
		///</summary>
		
		private long? categoryId_;
		
		///<summary>
		/// 商品三级分类
		///</summary>
		
		private string categoryName_;
		
		///<summary>
		/// 商品类型：0-自营，1-MP
		///</summary>
		
		private int? sourceType_;
		
		///<summary>
		/// 市场价（元）
		///</summary>
		
		private string marketPrice_;
		
		///<summary>
		/// 唯品价（元）
		///</summary>
		
		private string vipPrice_;
		
		///<summary>
		/// 佣金比例（%）
		///</summary>
		
		private string commissionRate_;
		
		///<summary>
		/// 佣金金额（元）
		///</summary>
		
		private string commission_;
		
		///<summary>
		/// 折扣
		///</summary>
		
		private string discount_;
		
		///<summary>
		/// 商品详情图片：根据商品id查询商品信息时返回，商品列表不返回
		///</summary>
		
		private List<string> goodsDetailPictures_;
		
		///<summary>
		/// 商品一级分类id
		///</summary>
		
		private long? cat1stId_;
		
		///<summary>
		/// 商品一级分类名称
		///</summary>
		
		private string cat1stName_;
		
		///<summary>
		/// 商品二级分类id
		///</summary>
		
		private long? cat2ndId_;
		
		///<summary>
		/// 商品二级分类名称
		///</summary>
		
		private string cat2ndName_;
		
		///<summary>
		/// 商品品牌sn
		///</summary>
		
		private string brandStoreSn_;
		
		///<summary>
		/// 商品品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 商品品牌logo全路径地址
		///</summary>
		
		private string brandLogoFull_;
		
		///<summary>
		/// 商品推广计划有效期预估截止时间：仅为预估时间，仅做参考；时间戳，单位：毫秒
		///</summary>
		
		private long? schemeEndTime_;
		
		///<summary>
		/// 商品售卖开始时间,时间戳，单位毫秒
		///</summary>
		
		private long? sellTimeFrom_;
		
		///<summary>
		/// 商品售卖结束时间,时间戳, 单位毫秒
		///</summary>
		
		private long? sellTimeTo_;
		
		///<summary>
		/// 推广权重，用于确定推广该商品的优先级，权重值越大，优先级越高
		///</summary>
		
		private int? weight_;
		
		///<summary>
		/// 店铺信息
		///</summary>
		
		private com.vip.adp.api.open.service.StoreInfo storeInfo_;
		
		///<summary>
		/// 商品评价信息
		///</summary>
		
		private com.vip.adp.api.open.service.GoodsCommentsInfo commentsInfo_;
		
		///<summary>
		/// 商品所属店铺服务能力评价:预留字段
		///</summary>
		
		private com.vip.adp.api.open.service.StoreServiceCapability storeServiceCapability_;
		
		///<summary>
		/// 商品所属档期（专场）id
		///</summary>
		
		private long? brandId_;
		
		///<summary>
		/// 商品所属推广方案开始时间：时间戳，单位：毫秒
		///</summary>
		
		private long? schemeStartTime_;
		
		public string GetGoodsId(){
			return this.goodsId_;
		}
		
		public void SetGoodsId(string value){
			this.goodsId_ = value;
		}
		public string GetGoodsName(){
			return this.goodsName_;
		}
		
		public void SetGoodsName(string value){
			this.goodsName_ = value;
		}
		public string GetGoodsDesc(){
			return this.goodsDesc_;
		}
		
		public void SetGoodsDesc(string value){
			this.goodsDesc_ = value;
		}
		public string GetDestUrl(){
			return this.destUrl_;
		}
		
		public void SetDestUrl(string value){
			this.destUrl_ = value;
		}
		public string GetGoodsThumbUrl(){
			return this.goodsThumbUrl_;
		}
		
		public void SetGoodsThumbUrl(string value){
			this.goodsThumbUrl_ = value;
		}
		public List<string> GetGoodsCarouselPictures(){
			return this.goodsCarouselPictures_;
		}
		
		public void SetGoodsCarouselPictures(List<string> value){
			this.goodsCarouselPictures_ = value;
		}
		public string GetGoodsMainPicture(){
			return this.goodsMainPicture_;
		}
		
		public void SetGoodsMainPicture(string value){
			this.goodsMainPicture_ = value;
		}
		public long? GetCategoryId(){
			return this.categoryId_;
		}
		
		public void SetCategoryId(long? value){
			this.categoryId_ = value;
		}
		public string GetCategoryName(){
			return this.categoryName_;
		}
		
		public void SetCategoryName(string value){
			this.categoryName_ = value;
		}
		public int? GetSourceType(){
			return this.sourceType_;
		}
		
		public void SetSourceType(int? value){
			this.sourceType_ = value;
		}
		public string GetMarketPrice(){
			return this.marketPrice_;
		}
		
		public void SetMarketPrice(string value){
			this.marketPrice_ = value;
		}
		public string GetVipPrice(){
			return this.vipPrice_;
		}
		
		public void SetVipPrice(string value){
			this.vipPrice_ = value;
		}
		public string GetCommissionRate(){
			return this.commissionRate_;
		}
		
		public void SetCommissionRate(string value){
			this.commissionRate_ = value;
		}
		public string GetCommission(){
			return this.commission_;
		}
		
		public void SetCommission(string value){
			this.commission_ = value;
		}
		public string GetDiscount(){
			return this.discount_;
		}
		
		public void SetDiscount(string value){
			this.discount_ = value;
		}
		public List<string> GetGoodsDetailPictures(){
			return this.goodsDetailPictures_;
		}
		
		public void SetGoodsDetailPictures(List<string> value){
			this.goodsDetailPictures_ = value;
		}
		public long? GetCat1stId(){
			return this.cat1stId_;
		}
		
		public void SetCat1stId(long? value){
			this.cat1stId_ = value;
		}
		public string GetCat1stName(){
			return this.cat1stName_;
		}
		
		public void SetCat1stName(string value){
			this.cat1stName_ = value;
		}
		public long? GetCat2ndId(){
			return this.cat2ndId_;
		}
		
		public void SetCat2ndId(long? value){
			this.cat2ndId_ = value;
		}
		public string GetCat2ndName(){
			return this.cat2ndName_;
		}
		
		public void SetCat2ndName(string value){
			this.cat2ndName_ = value;
		}
		public string GetBrandStoreSn(){
			return this.brandStoreSn_;
		}
		
		public void SetBrandStoreSn(string value){
			this.brandStoreSn_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetBrandLogoFull(){
			return this.brandLogoFull_;
		}
		
		public void SetBrandLogoFull(string value){
			this.brandLogoFull_ = value;
		}
		public long? GetSchemeEndTime(){
			return this.schemeEndTime_;
		}
		
		public void SetSchemeEndTime(long? value){
			this.schemeEndTime_ = value;
		}
		public long? GetSellTimeFrom(){
			return this.sellTimeFrom_;
		}
		
		public void SetSellTimeFrom(long? value){
			this.sellTimeFrom_ = value;
		}
		public long? GetSellTimeTo(){
			return this.sellTimeTo_;
		}
		
		public void SetSellTimeTo(long? value){
			this.sellTimeTo_ = value;
		}
		public int? GetWeight(){
			return this.weight_;
		}
		
		public void SetWeight(int? value){
			this.weight_ = value;
		}
		public com.vip.adp.api.open.service.StoreInfo GetStoreInfo(){
			return this.storeInfo_;
		}
		
		public void SetStoreInfo(com.vip.adp.api.open.service.StoreInfo value){
			this.storeInfo_ = value;
		}
		public com.vip.adp.api.open.service.GoodsCommentsInfo GetCommentsInfo(){
			return this.commentsInfo_;
		}
		
		public void SetCommentsInfo(com.vip.adp.api.open.service.GoodsCommentsInfo value){
			this.commentsInfo_ = value;
		}
		public com.vip.adp.api.open.service.StoreServiceCapability GetStoreServiceCapability(){
			return this.storeServiceCapability_;
		}
		
		public void SetStoreServiceCapability(com.vip.adp.api.open.service.StoreServiceCapability value){
			this.storeServiceCapability_ = value;
		}
		public long? GetBrandId(){
			return this.brandId_;
		}
		
		public void SetBrandId(long? value){
			this.brandId_ = value;
		}
		public long? GetSchemeStartTime(){
			return this.schemeStartTime_;
		}
		
		public void SetSchemeStartTime(long? value){
			this.schemeStartTime_ = value;
		}
		
	}
	
}