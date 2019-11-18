using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class UserLogRequestModel {
		
		///<summary>
		/// 用户id
		///</summary>
		
		private string userId_;
		
		///<summary>
		/// activity&command&special&payment主键
		///</summary>
		
		private string refId_;
		
		///<summary>
		/// 1. activity  2. command  3. special  4. payment
		///</summary>
		
		private byte? refIdType_;
		
		///<summary>
		/// activityNo&commandNo&specialNo&paymentNo
		///</summary>
		
		private string refNo_;
		
		///<summary>
		/// 定单号order_sn
		///</summary>
		
		private string orderNo_;
		
		///<summary>
		/// 1:参加 2:取消
		///</summary>
		
		private int? action_;
		
		///<summary>
		/// 定单原始金额
		///</summary>
		
		private double? orderAmount_;
		
		///<summary>
		/// 定单优惠金额/数量
		///</summary>
		
		private double? orderFav_;
		
		///<summary>
		/// hash唯一值
		///</summary>
		
		private string orderHash_;
		
		///<summary>
		/// 定单优惠分摊列表
		///</summary>
		
		private List<com.vip.pms.data.service.PromotionOrderGoodsModel> orderGoodsList_;
		
		///<summary>
		/// 父订单。用于表明口令红包中同一组拆单的订单
		///</summary>
		
		private string parentHashCode_;
		
		///<summary>
		/// 活动类型
		///</summary>
		
		private byte? activityType_;
		
		public string GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(string value){
			this.userId_ = value;
		}
		public string GetRefId(){
			return this.refId_;
		}
		
		public void SetRefId(string value){
			this.refId_ = value;
		}
		public byte? GetRefIdType(){
			return this.refIdType_;
		}
		
		public void SetRefIdType(byte? value){
			this.refIdType_ = value;
		}
		public string GetRefNo(){
			return this.refNo_;
		}
		
		public void SetRefNo(string value){
			this.refNo_ = value;
		}
		public string GetOrderNo(){
			return this.orderNo_;
		}
		
		public void SetOrderNo(string value){
			this.orderNo_ = value;
		}
		public int? GetAction(){
			return this.action_;
		}
		
		public void SetAction(int? value){
			this.action_ = value;
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
		public string GetOrderHash(){
			return this.orderHash_;
		}
		
		public void SetOrderHash(string value){
			this.orderHash_ = value;
		}
		public List<com.vip.pms.data.service.PromotionOrderGoodsModel> GetOrderGoodsList(){
			return this.orderGoodsList_;
		}
		
		public void SetOrderGoodsList(List<com.vip.pms.data.service.PromotionOrderGoodsModel> value){
			this.orderGoodsList_ = value;
		}
		public string GetParentHashCode(){
			return this.parentHashCode_;
		}
		
		public void SetParentHashCode(string value){
			this.parentHashCode_ = value;
		}
		public byte? GetActivityType(){
			return this.activityType_;
		}
		
		public void SetActivityType(byte? value){
			this.activityType_ = value;
		}
		
	}
	
}