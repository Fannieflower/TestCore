using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.visPo.service{
	
	
	
	
	
	public class EBSData {
		
		///<summary>
		/// PO创建流水（长度50）：
		///
		///VIS_PO_1243243235235
		///</summary>
		
		private string reqIebsFlowNum_;
		
		///<summary>
		/// PO号码
		///</summary>
		
		private string po_;
		
		///<summary>
		/// PO行数
		///</summary>
		
		private string poCount_;
		
		///<summary>
		/// PO创建时间
		///</summary>
		
		private string createDate_;
		
		///<summary>
		///</summary>
		
		private int? batchNum_;
		
		public string GetReqIebsFlowNum(){
			return this.reqIebsFlowNum_;
		}
		
		public void SetReqIebsFlowNum(string value){
			this.reqIebsFlowNum_ = value;
		}
		public string GetPo(){
			return this.po_;
		}
		
		public void SetPo(string value){
			this.po_ = value;
		}
		public string GetPoCount(){
			return this.poCount_;
		}
		
		public void SetPoCount(string value){
			this.poCount_ = value;
		}
		public string GetCreateDate(){
			return this.createDate_;
		}
		
		public void SetCreateDate(string value){
			this.createDate_ = value;
		}
		public int? GetBatchNum(){
			return this.batchNum_;
		}
		
		public void SetBatchNum(int? value){
			this.batchNum_ = value;
		}
		
	}
	
}