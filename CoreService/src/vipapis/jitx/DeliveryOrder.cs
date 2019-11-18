using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class DeliveryOrder {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 当前可供选择的仓库列表
		///</summary>
		
		private List<string> available_warehouses_;
		
		///<summary>
		/// 寻仓状态：NEW:新增，需要供应商进行寻仓判定; CONFIRMING:确认中,在寻仓超时前供应商若通过responseJitXDeliveryRequest返回feedback_state = SUCCESS & delivery_warehouse为非空值，则判定为本状态;CONFIRMED:经过系列判定后，最终判定JITX; ROLLBACK:经过系列判定后，最终判定为非JITX
		///</summary>
		
		private string status_;
		
		///<summary>
		/// 订单状态说明
		///</summary>
		
		private string status_remark_;
		
		///<summary>
		/// 收货人地址
		/// @sampleValue buyer_address 广东省.广州市.荔湾区
		///</summary>
		
		private string buyer_address_;
		
		///<summary>
		/// 对应状态的最后更新时间，格式：yyyy-MM-dd HH:mm:ss
		///</summary>
		
		private string update_time_;
		
		///<summary>
		/// 寻仓明细
		///</summary>
		
		private List<vipapis.jitx.DeliveryOrderDetail> delivery_order_details_;
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public List<string> GetAvailable_warehouses(){
			return this.available_warehouses_;
		}
		
		public void SetAvailable_warehouses(List<string> value){
			this.available_warehouses_ = value;
		}
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		public string GetStatus_remark(){
			return this.status_remark_;
		}
		
		public void SetStatus_remark(string value){
			this.status_remark_ = value;
		}
		public string GetBuyer_address(){
			return this.buyer_address_;
		}
		
		public void SetBuyer_address(string value){
			this.buyer_address_ = value;
		}
		public string GetUpdate_time(){
			return this.update_time_;
		}
		
		public void SetUpdate_time(string value){
			this.update_time_ = value;
		}
		public List<vipapis.jitx.DeliveryOrderDetail> GetDelivery_order_details(){
			return this.delivery_order_details_;
		}
		
		public void SetDelivery_order_details(List<vipapis.jitx.DeliveryOrderDetail> value){
			this.delivery_order_details_ = value;
		}
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		
	}
	
}