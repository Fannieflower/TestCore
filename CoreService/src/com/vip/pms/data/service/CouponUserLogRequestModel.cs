using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class CouponUserLogRequestModel {
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 券号
		///</summary>
		
		private string couponSn_;
		
		///<summary>
		/// 定单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 定单原始金额
		///</summary>
		
		private double? orderAmount_;
		
		///<summary>
		/// 定单优惠金额/数量
		///</summary>
		
		private double? orderFav_;
		
		///<summary>
		/// 表明id来自哪个表： 1. activity 2. command 3. special 4. payment 5. coupon 6. coupon dispatch group
		///</summary>
		
		private byte? refIdType_;
		
		///<summary>
		/// 营销主表id，由ref_id_type定义
		///</summary>
		
		private long? refId_;
		
		///<summary>
		/// 定单优惠分摊列表
		///</summary>
		
		private List<com.vip.pms.data.service.CouponPromotionOrderGoodsModel> orderGoodsList_;
		
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public string GetCouponSn(){
			return this.couponSn_;
		}
		
		public void SetCouponSn(string value){
			this.couponSn_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public double? GetOrderAmount(){
			return this.orderAmount_;
		}
		
		public void SetOrderAmount(double? value){
			this.orderAmount_ = value;
		}
		public double? GetOrderFav(){
			return this.orderFav_;
		}
		
		public void SetOrderFav(double? value){
			this.orderFav_ = value;
		}
		public byte? GetRefIdType(){
			return this.refIdType_;
		}
		
		public void SetRefIdType(byte? value){
			this.refIdType_ = value;
		}
		public long? GetRefId(){
			return this.refId_;
		}
		
		public void SetRefId(long? value){
			this.refId_ = value;
		}
		public List<com.vip.pms.data.service.CouponPromotionOrderGoodsModel> GetOrderGoodsList(){
			return this.orderGoodsList_;
		}
		
		public void SetOrderGoodsList(List<com.vip.pms.data.service.CouponPromotionOrderGoodsModel> value){
			this.orderGoodsList_ = value;
		}
		
	}
	
}