using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class BelleDeliveryOrder {
		
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
		
		private List<vipapis.jitx.WarehousingOrderDetail> warehousing_order_details_;
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 已确认发货仓库
		///</summary>
		
		private string confirmed_delivery_warehouse_;
		
		///<summary>
		/// 省份
		/// @sampleValue buyer_province 广东省
		///</summary>
		
		private string buyer_province_;
		
		///<summary>
		/// 城市
		/// @sampleValue buyer_city 广州市
		///</summary>
		
		private string buyer_city_;
		
		///<summary>
		/// 区域
		/// @sampleValue buyer_county 荔湾区
		///</summary>
		
		private string buyer_county_;
		
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
		public List<vipapis.jitx.WarehousingOrderDetail> GetWarehousing_order_details(){
			return this.warehousing_order_details_;
		}
		
		public void SetWarehousing_order_details(List<vipapis.jitx.WarehousingOrderDetail> value){
			this.warehousing_order_details_ = value;
		}
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public string GetConfirmed_delivery_warehouse(){
			return this.confirmed_delivery_warehouse_;
		}
		
		public void SetConfirmed_delivery_warehouse(string value){
			this.confirmed_delivery_warehouse_ = value;
		}
		public string GetBuyer_province(){
			return this.buyer_province_;
		}
		
		public void SetBuyer_province(string value){
			this.buyer_province_ = value;
		}
		public string GetBuyer_city(){
			return this.buyer_city_;
		}
		
		public void SetBuyer_city(string value){
			this.buyer_city_ = value;
		}
		public string GetBuyer_county(){
			return this.buyer_county_;
		}
		
		public void SetBuyer_county(string value){
			this.buyer_county_ = value;
		}
		
	}
	
}