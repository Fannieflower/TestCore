using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponPromotionOrderGoodsModel {
		
		///<summary>
		/// 商品ID
		///</summary>
		
		private string goodsId_;
		
		///<summary>
		/// 商品尺码ID
		///</summary>
		
		private string sizeId_;
		
		///<summary>
		/// 商品数量
		///</summary>
		
		private double? goodsNumber_;
		
		///<summary>
		/// 优惠金额 
		///</summary>
		
		private double? favAmount_;
		
		///<summary>
		/// 总优惠金额=fav_amount*goods_number
		///</summary>
		
		private double? totalFavAmount_;
		
		///<summary>
		/// 券号
		///</summary>
		
		private string couponSn_;
		
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
		public double? GetGoodsNumber(){
			return this.goodsNumber_;
		}
		
		public void SetGoodsNumber(double? value){
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
		public string GetCouponSn(){
			return this.couponSn_;
		}
		
		public void SetCouponSn(string value){
			this.couponSn_ = value;
		}
		
	}
	
}