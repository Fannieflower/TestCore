using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class RefInfoModel {
		
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
		/// 定单参与某Ref的优惠金额/数量
		///</summary>
		
		private double? orderFav_;
		
		///<summary>
		/// 定单优惠分摊列表
		///</summary>
		
		private List<com.vip.pms.data.service.PromotionOrderGoodsModel> orderGoodsList_;
		
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
		public double? GetOrderFav(){
			return this.orderFav_;
		}
		
		public void SetOrderFav(double? value){
			this.orderFav_ = value;
		}
		public List<com.vip.pms.data.service.PromotionOrderGoodsModel> GetOrderGoodsList(){
			return this.orderGoodsList_;
		}
		
		public void SetOrderGoodsList(List<com.vip.pms.data.service.PromotionOrderGoodsModel> value){
			this.orderGoodsList_ = value;
		}
		
	}
	
}