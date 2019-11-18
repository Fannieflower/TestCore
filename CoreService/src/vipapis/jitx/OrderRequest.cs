using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class OrderRequest {
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 订单状态; 10：订单已审核；22：订单已发货；23：订单已揽收 ；97_22：已发货取消；97_10：未发货取消；97_23：已揽收取消
		///</summary>
		
		private List<string> order_status_;
		
		///<summary>
		/// 查询开始时间(epoch格式时间戳)，且小于endTime，例如：12月1日调用接口，最早可查询9月1日的订单数据（向前推三个月）
		/// @sampleValue start_time 1545876212
		///</summary>
		
		private long? start_time_;
		
		///<summary>
		/// 查询结束时间（epoch格式时间戳），大于startTime，endTime-startTime最大不可超过30分钟
		/// @sampleValue end_time 1545876212
		///</summary>
		
		private long? end_time_;
		
		///<summary>
		/// 页码：默认为：1
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页的条数（最大1000条）
		///</summary>
		
		private int? limit_;
		
		///<summary>
		/// 合作编码,最大20个
		///</summary>
		
		private List<string> cooperation_nos_;
		
		///<summary>
		/// 发货仓库,最大支持20个
		///</summary>
		
		private List<string> delivery_warehouse_codes_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public List<string> GetOrder_status(){
			return this.order_status_;
		}
		
		public void SetOrder_status(List<string> value){
			this.order_status_ = value;
		}
		public long? GetStart_time(){
			return this.start_time_;
		}
		
		public void SetStart_time(long? value){
			this.start_time_ = value;
		}
		public long? GetEnd_time(){
			return this.end_time_;
		}
		
		public void SetEnd_time(long? value){
			this.end_time_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		public List<string> GetCooperation_nos(){
			return this.cooperation_nos_;
		}
		
		public void SetCooperation_nos(List<string> value){
			this.cooperation_nos_ = value;
		}
		public List<string> GetDelivery_warehouse_codes(){
			return this.delivery_warehouse_codes_;
		}
		
		public void SetDelivery_warehouse_codes(List<string> value){
			this.delivery_warehouse_codes_ = value;
		}
		
	}
	
}