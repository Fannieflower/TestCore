using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class OrderFavDetail {
		
		///<summary>
		/// 商品ID（sizeId）
		///</summary>
		
		private string sizeId_;
		
		///<summary>
		/// 商品总数
		///</summary>
		
		private int? goodsNumber_;
		
		///<summary>
		/// 单件商品优惠金额
		///</summary>
		
		private double? favAmount_;
		
		public string GetSizeId(){
			return this.sizeId_;
		}
		
		public void SetSizeId(string value){
			this.sizeId_ = value;
		}
		public int? GetGoodsNumber(){
			return this.goodsNumber_;
		}
		
		public void SetGoodsNumber(int? value){
			this.goodsNumber_ = value;
		}
		public double? GetFavAmount(){
			return this.favAmount_;
		}
		
		public void SetFavAmount(double? value){
			this.favAmount_ = value;
		}
		
	}
	
}