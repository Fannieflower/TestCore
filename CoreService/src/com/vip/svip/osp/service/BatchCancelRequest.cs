using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class BatchCancelRequest {
		
		///<summary>
		/// 批次号
		///</summary>
		
		private string batchNo_;
		
		///<summary>
		/// 清退用户列表
		///</summary>
		
		private List<com.vip.svip.osp.service.CancelUser> userList_;
		
		public string GetBatchNo(){
			return this.batchNo_;
		}
		
		public void SetBatchNo(string value){
			this.batchNo_ = value;
		}
		public List<com.vip.svip.osp.service.CancelUser> GetUserList(){
			return this.userList_;
		}
		
		public void SetUserList(List<com.vip.svip.osp.service.CancelUser> value){
			this.userList_ = value;
		}
		
	}
	
}