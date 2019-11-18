using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class PromotionOrderGoodsModel {
		
		///<summary>
		/// 商品尺码ID
		///</summary>
		
		private string goodsId_;
		
		///<summary>
		/// 商品数量
		///</summary>
		
		private int? goodsNumber_;
		
		///<summary>
		/// 优惠金额 
		///</summary>
		
		private double? favAmount_;
		
		///<summary>
		/// 总优惠金额=fav_amount*goods_number
		///</summary>
		
		private double? totalFavAmount_;
		
		public string GetGoodsId(){
			return this.goodsId_;
		}
		
		public void SetGoodsId(string value){
			this.goodsId_ = value;
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
		public double? GetTotalFavAmount(){
			return this.totalFavAmount_;
		}
		
		public void SetTotalFavAmount(double? value){
			this.totalFavAmount_ = value;
		}
		
	}
	
}