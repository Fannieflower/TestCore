using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.cache{
	
	
	
	
	
	public class RefreshCacheParam {
		
		///<summary>
		/// 承运商代码
		///</summary>
		
		private string custCode_;
		
		///<summary>
		/// 所属仓库
		///</summary>
		
		private string createdOffice_;
		
		///<summary>
		/// 区县
		///</summary>
		
		private string custRegion_;
		
		///<summary>
		/// 镇街
		///</summary>
		
		private string custTown_;
		
		public string GetCustCode(){
			return this.custCode_;
		}
		
		public void SetCustCode(string value){
			this.custCode_ = value;
		}
		public string GetCreatedOffice(){
			return this.createdOffice_;
		}
		
		public void SetCreatedOffice(string value){
			this.createdOffice_ = value;
		}
		public string GetCustRegion(){
			return this.custRegion_;
		}
		
		public void SetCustRegion(string value){
			this.custRegion_ = value;
		}
		public string GetCustTown(){
			return this.custTown_;
		}
		
		public void SetCustTown(string value){
			this.custTown_ = value;
		}
		
	}
	
}