using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.carrier.service{
	
	
	
	
	
	public class LoadingListResp {
		
		///<summary>
		/// 批次号
		///</summary>
		
		private string batch_no_;
		
		///<summary>
		/// 装载明细处理结果
		///</summary>
		
		private List<com.vip.vop.logistics.carrier.service.LoadingItemProcessResult> loading_item_process_results_;
		
		public string GetBatch_no(){
			return this.batch_no_;
		}
		
		public void SetBatch_no(string value){
			this.batch_no_ = value;
		}
		public List<com.vip.vop.logistics.carrier.service.LoadingItemProcessResult> GetLoading_item_process_results(){
			return this.loading_item_process_results_;
		}
		
		public void SetLoading_item_process_results(List<com.vip.vop.logistics.carrier.service.LoadingItemProcessResult> value){
			this.loading_item_process_results_ = value;
		}
		
	}
	
}