using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetOpGoodsDetailItem {
		
		///<summary>
		/// 专场ID
		///</summary>
		
		private string salesNo_;
		
		///<summary>
		/// 品牌名称
		///</summary>
		
		private string brandName_;
		
		///<summary>
		/// 一句话卖点
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 商品ID
		///</summary>
		
		private string goodsId_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string goodsName_;
		
		///<summary>
		/// 商品图片
		///</summary>
		
		private string goodsImg_;
		
		///<summary>
		/// 销售价
		///</summary>
		
		private string price_;
		
		///<summary>
		/// 活动价
		///</summary>
		
		private string vipPrice_;
		
		///<summary>
		/// 是否多sku同价
		///</summary>
		
		private bool? multiSkuSamePrice_;
		
		///<summary>
		/// 销售状态
		///</summary>
		
		private int? saleState_;
		
		public string GetSalesNo(){
			return this.salesNo_;
		}
		
		public void SetSalesNo(string value){
			this.salesNo_ = value;
		}
		public string GetBrandName(){
			return this.brandName_;
		}
		
		public void SetBrandName(string value){
			this.brandName_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
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
		public string GetGoodsImg(){
			return this.goodsImg_;
		}
		
		public void SetGoodsImg(string value){
			this.goodsImg_ = value;
		}
		public string GetPrice(){
			return this.price_;
		}
		
		public void SetPrice(string value){
			this.price_ = value;
		}
		public string GetVipPrice(){
			return this.vipPrice_;
		}
		
		public void SetVipPrice(string value){
			this.vipPrice_ = value;
		}
		public bool? GetMultiSkuSamePrice(){
			return this.multiSkuSamePrice_;
		}
		
		public void SetMultiSkuSamePrice(bool? value){
			this.multiSkuSamePrice_ = value;
		}
		public int? GetSaleState(){
			return this.saleState_;
		}
		
		public void SetSaleState(int? value){
			this.saleState_ = value;
		}
		
	}
	
}