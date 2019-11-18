using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class OldPmsOrderRequestModel {
		
		///<summary>
		/// 定单号order_sn
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 定单优惠金额
		///</summary>
		
		private double? fav_;
		
		///<summary>
		/// 1. activity  2. command  3. special  4. payment
		///</summary>
		
		private int? refIdType_;
		
		///<summary>
		/// 定单优惠分摊列表
		///</summary>
		
		private List<com.vip.pms.data.service.OldPmsOrderGoodsModel> orderGoodsList_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public double? GetFav(){
			return this.fav_;
		}
		
		public void SetFav(double? value){
			this.fav_ = value;
		}
		public int? GetRefIdType(){
			return this.refIdType_;
		}
		
		public void SetRefIdType(int? value){
			this.refIdType_ = value;
		}
		public List<com.vip.pms.data.service.OldPmsOrderGoodsModel> GetOrderGoodsList(){
			return this.orderGoodsList_;
		}
		
		public void SetOrderGoodsList(List<com.vip.pms.data.service.OldPmsOrderGoodsModel> value){
			this.orderGoodsList_ = value;
		}
		
	}
	
}