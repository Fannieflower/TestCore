using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class RefundOrderDetail {
		
		///<summary>
		/// 商品id
		///</summary>
		
		private string goodsId_;
		
		///<summary>
		/// 商品尺码id
		///</summary>
		
		private string sizeId_;
		
		///<summary>
		/// 商品价格：元
		///</summary>
		
		private string goodsPrice_;
		
		///<summary>
		/// 维权商品数量
		///</summary>
		
		private int? goodsCount_;
		
		///<summary>
		/// 维权商品佣金
		///</summary>
		
		private string commission_;
		
		///<summary>
		/// 维权商品计佣金额
		///</summary>
		
		private string totalCost_;
		
		public string GetGoodsId(){
			return this.goodsId_;
		}
		
		public void SetGoodsId(string value){
			this.goodsId_ = value;
		}
		public string GetSizeId(){
			return this.sizeId_;
		}
		
		public void SetSizeId(string value){
			this.sizeId_ = value;
		}
		public string GetGoodsPrice(){
			return this.goodsPrice_;
		}
		
		public void SetGoodsPrice(string value){
			this.goodsPrice_ = value;
		}
		public int? GetGoodsCount(){
			return this.goodsCount_;
		}
		
		public void SetGoodsCount(int? value){
			this.goodsCount_ = value;
		}
		public string GetCommission(){
			return this.commission_;
		}
		
		public void SetCommission(string value){
			this.commission_ = value;
		}
		public string GetTotalCost(){
			return this.totalCost_;
		}
		
		public void SetTotalCost(string value){
			this.totalCost_ = value;
		}
		
	}
	
}