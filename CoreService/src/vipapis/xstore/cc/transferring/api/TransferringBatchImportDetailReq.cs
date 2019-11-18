using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringBatchImportDetailReq {
		
		///<summary>
		/// 批次号
		///</summary>
		
		private string batch_no_;
		
		///<summary>
		/// 明细,每次最多100条
		///</summary>
		
		private List<vipapis.xstore.cc.transferring.api.TransferringBatchImportItem> items_;
		
		public string GetBatch_no(){
			return this.batch_no_;
		}
		
		public void SetBatch_no(string value){
			this.batch_no_ = value;
		}
		public List<vipapis.xstore.cc.transferring.api.TransferringBatchImportItem> GetItems(){
			return this.items_;
		}
		
		public void SetItems(List<vipapis.xstore.cc.transferring.api.TransferringBatchImportItem> value){
			this.items_ = value;
		}
		
	}
	
}