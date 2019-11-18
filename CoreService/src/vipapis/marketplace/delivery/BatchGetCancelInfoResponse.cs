using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.delivery{
	
	
	
	
	
	public class BatchGetCancelInfoResponse {
		
		///<summary>
		/// 总数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 取消申请单列表
		///</summary>
		
		private List<vipapis.marketplace.delivery.GetCancelInfoResponse> cancelInfos_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.marketplace.delivery.GetCancelInfoResponse> GetCancelInfos(){
			return this.cancelInfos_;
		}
		
		public void SetCancelInfos(List<vipapis.marketplace.delivery.GetCancelInfoResponse> value){
			this.cancelInfos_ = value;
		}
		
	}
	
}