using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.order{
	
	
	
	
	
	public class WayBill {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string expressNo_;
		
		///<summary>
		/// 发货时间
		///</summary>
		
		private long? deliveryTime_;
		
		///<summary>
		/// 商品信息
		///</summary>
		
		private List<com.vip.vop.vcloud.order.SkuItem> skuItems_;
		
		///<summary>
		/// 子订单号
		///</summary>
		
		private string subOrderSn_;
		
		///<summary>
		/// 订单备注
		///</summary>
		
		private string orderRemark_;
		
		///<summary>
		/// 门店是否已确认
		///</summary>
		
		private int? isConfirmed_;
		
		///<summary>
		/// 门店ID
		///</summary>
		
		private long? warehouseId_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetExpressNo(){
			return this.expressNo_;
		}
		
		public void SetExpressNo(string value){
			this.expressNo_ = value;
		}
		public long? GetDeliveryTime(){
			return this.deliveryTime_;
		}
		
		public void SetDeliveryTime(long? value){
			this.deliveryTime_ = value;
		}
		public List<com.vip.vop.vcloud.order.SkuItem> GetSkuItems(){
			return this.skuItems_;
		}
		
		public void SetSkuItems(List<com.vip.vop.vcloud.order.SkuItem> value){
			this.skuItems_ = value;
		}
		public string GetSubOrderSn(){
			return this.subOrderSn_;
		}
		
		public void SetSubOrderSn(string value){
			this.subOrderSn_ = value;
		}
		public string GetOrderRemark(){
			return this.orderRemark_;
		}
		
		public void SetOrderRemark(string value){
			this.orderRemark_ = value;
		}
		public int? GetIsConfirmed(){
			return this.isConfirmed_;
		}
		
		public void SetIsConfirmed(int? value){
			this.isConfirmed_ = value;
		}
		public long? GetWarehouseId(){
			return this.warehouseId_;
		}
		
		public void SetWarehouseId(long? value){
			this.warehouseId_ = value;
		}
		
	}
	
}