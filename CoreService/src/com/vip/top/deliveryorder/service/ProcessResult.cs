using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.deliveryorder.service{
	
	
	
	
	
	public class ProcessResult {
		
		///<summary>
		/// 物流单ID(TMS_ORDER表的tms_order_id字段值)
		///</summary>
		
		private string tmsOrderId_;
		
		///<summary>
		/// 所属仓库编码
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 是否需要匹配承运商
		///</summary>
		
		private bool? needMatchCarrier_;
		
		///<summary>
		/// 是否为新增
		///</summary>
		
		private bool? isNew_;
		
		public string GetTmsOrderId(){
			return this.tmsOrderId_;
		}
		
		public void SetTmsOrderId(string value){
			this.tmsOrderId_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public bool? GetNeedMatchCarrier(){
			return this.needMatchCarrier_;
		}
		
		public void SetNeedMatchCarrier(bool? value){
			this.needMatchCarrier_ = value;
		}
		public bool? GetIsNew(){
			return this.isNew_;
		}
		
		public void SetIsNew(bool? value){
			this.isNew_ = value;
		}
		
	}
	
}