using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.sims.erp{
	
	
	
	
	
	public class InventoryAdjustRsp {
		
		///<summary>
		/// 业务流水号 - 要全局唯一，用来保证幂等性
		///</summary>
		
		private string seqNo_;
		
		///<summary>
		/// 是否成功
		///</summary>
		
		private vipapis.xstore.cc.sims.erp.RspCodeEnum? resCode_;
		
		///<summary>
		/// 调用结果的描述
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// po分摊结果
		///</summary>
		
		private Dictionary<string, int?> poMap_;
		
		public string GetSeqNo(){
			return this.seqNo_;
		}
		
		public void SetSeqNo(string value){
			this.seqNo_ = value;
		}
		public vipapis.xstore.cc.sims.erp.RspCodeEnum? GetResCode(){
			return this.resCode_;
		}
		
		public void SetResCode(vipapis.xstore.cc.sims.erp.RspCodeEnum? value){
			this.resCode_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		public Dictionary<string, int?> GetPoMap(){
			return this.poMap_;
		}
		
		public void SetPoMap(Dictionary<string, int?> value){
			this.poMap_ = value;
		}
		
	}
	
}