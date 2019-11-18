using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class OrderDetailInfo {
		
		///<summary>
		/// 商品id
		///</summary>
		
		private string goodsId_;
		
		///<summary>
		/// 商品名称
		///</summary>
		
		private string goodsName_;
		
		///<summary>
		/// 商品缩略图
		///</summary>
		
		private string goodsThumb_;
		
		///<summary>
		/// 商品数量
		///</summary>
		
		private int? goodsCount_;
		
		///<summary>
		/// 商品计佣金额
		///</summary>
		
		private string commissionTotalCost_;
		
		///<summary>
		/// 商品佣金比例
		///</summary>
		
		private string commissionRate_;
		
		///<summary>
		/// 商品佣金金额
		///</summary>
		
		private string commission_;
		
		///<summary>
		/// 佣金编码：对应商品二级分类
		///</summary>
		
		private string commCode_;
		
		///<summary>
		/// 佣金方案名称
		///</summary>
		
		private string commName_;
		
		///<summary>
		/// 订单来源
		///</summary>
		
		private string orderSource_;
		
		///<summary>
		/// 商品售后信息
		///</summary>
		
		private List<com.vip.adp.api.open.service.AfterSaleDetailInfo> afterSaleInfo_;
		
		///<summary>
		/// 商品尺码：2019.01.01之后可用
		///</summary>
		
		private string sizeId_;
		
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
		public string GetGoodsThumb(){
			return this.goodsThumb_;
		}
		
		public void SetGoodsThumb(string value){
			this.goodsThumb_ = value;
		}
		public int? GetGoodsCount(){
			return this.goodsCount_;
		}
		
		public void SetGoodsCount(int? value){
			this.goodsCount_ = value;
		}
		public string GetCommissionTotalCost(){
			return this.commissionTotalCost_;
		}
		
		public void SetCommissionTotalCost(string value){
			this.commissionTotalCost_ = value;
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
		public string GetCommCode(){
			return this.commCode_;
		}
		
		public void SetCommCode(string value){
			this.commCode_ = value;
		}
		public string GetCommName(){
			return this.commName_;
		}
		
		public void SetCommName(string value){
			this.commName_ = value;
		}
		public string GetOrderSource(){
			return this.orderSource_;
		}
		
		public void SetOrderSource(string value){
			this.orderSource_ = value;
		}
		public List<com.vip.adp.api.open.service.AfterSaleDetailInfo> GetAfterSaleInfo(){
			return this.afterSaleInfo_;
		}
		
		public void SetAfterSaleInfo(List<com.vip.adp.api.open.service.AfterSaleDetailInfo> value){
			this.afterSaleInfo_ = value;
		}
		public string GetSizeId(){
			return this.sizeId_;
		}
		
		public void SetSizeId(string value){
			this.sizeId_ = value;
		}
		
	}
	
}