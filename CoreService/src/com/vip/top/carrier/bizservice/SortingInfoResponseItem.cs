using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class SortingInfoResponseItem {
		
		///<summary>
		/// 分拣码
		///</summary>
		
		private string sortingCode_;
		
		///<summary>
		/// 站点代码
		///</summary>
		
		private string carrierPointCode_;
		
		///<summary>
		/// 站点名称
		///</summary>
		
		private string carrierPointName_;
		
		///<summary>
		/// 参考单号
		///</summary>
		
		private string referenceNo_;
		
		///<summary>
		/// 状态码
		///</summary>
		
		private string bizCode_;
		
		///<summary>
		/// 返回信息 正常情况为空，异常情况，返回异常原因
		///</summary>
		
		private string bizMsg_;
		
		public string GetSortingCode(){
			return this.sortingCode_;
		}
		
		public void SetSortingCode(string value){
			this.sortingCode_ = value;
		}
		public string GetCarrierPointCode(){
			return this.carrierPointCode_;
		}
		
		public void SetCarrierPointCode(string value){
			this.carrierPointCode_ = value;
		}
		public string GetCarrierPointName(){
			return this.carrierPointName_;
		}
		
		public void SetCarrierPointName(string value){
			this.carrierPointName_ = value;
		}
		public string GetReferenceNo(){
			return this.referenceNo_;
		}
		
		public void SetReferenceNo(string value){
			this.referenceNo_ = value;
		}
		public string GetBizCode(){
			return this.bizCode_;
		}
		
		public void SetBizCode(string value){
			this.bizCode_ = value;
		}
		public string GetBizMsg(){
			return this.bizMsg_;
		}
		
		public void SetBizMsg(string value){
			this.bizMsg_ = value;
		}
		
	}
	
}