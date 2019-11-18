using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class OrderDeliveryInfo {
		
		///<summary>
		/// 干线承运商代码
		///</summary>
		
		private string mainCustCode_;
		
		///<summary>
		/// 干线承运商名称
		///</summary>
		
		private string mainCustName_;
		
		///<summary>
		/// 快递/落地配代码
		///</summary>
		
		private string custCode_;
		
		///<summary>
		/// 快递/落地配名称
		///</summary>
		
		private string custName_;
		
		///<summary>
		/// 预计总体到货时间
		///</summary>
		
		private string expectedSignTime_;
		
		///<summary>
		/// 预计干线到货时间
		///</summary>
		
		private string expectedTrunkTime_;
		
		///<summary>
		/// 实际总体到货时间
		///</summary>
		
		private string signTime_;
		
		///<summary>
		/// 实际干线到货时间
		///</summary>
		
		private string trunkTime_;
		
		///<summary>
		/// 配送类型2:表示干线+落地配,5:表示快递
		///</summary>
		
		private int? custType_;
		
		///<summary>
		/// 快递/落地配时效
		///</summary>
		
		private int? timeLiness_;
		
		public string GetMainCustCode(){
			return this.mainCustCode_;
		}
		
		public void SetMainCustCode(string value){
			this.mainCustCode_ = value;
		}
		public string GetMainCustName(){
			return this.mainCustName_;
		}
		
		public void SetMainCustName(string value){
			this.mainCustName_ = value;
		}
		public string GetCustCode(){
			return this.custCode_;
		}
		
		public void SetCustCode(string value){
			this.custCode_ = value;
		}
		public string GetCustName(){
			return this.custName_;
		}
		
		public void SetCustName(string value){
			this.custName_ = value;
		}
		public string GetExpectedSignTime(){
			return this.expectedSignTime_;
		}
		
		public void SetExpectedSignTime(string value){
			this.expectedSignTime_ = value;
		}
		public string GetExpectedTrunkTime(){
			return this.expectedTrunkTime_;
		}
		
		public void SetExpectedTrunkTime(string value){
			this.expectedTrunkTime_ = value;
		}
		public string GetSignTime(){
			return this.signTime_;
		}
		
		public void SetSignTime(string value){
			this.signTime_ = value;
		}
		public string GetTrunkTime(){
			return this.trunkTime_;
		}
		
		public void SetTrunkTime(string value){
			this.trunkTime_ = value;
		}
		public int? GetCustType(){
			return this.custType_;
		}
		
		public void SetCustType(int? value){
			this.custType_ = value;
		}
		public int? GetTimeLiness(){
			return this.timeLiness_;
		}
		
		public void SetTimeLiness(int? value){
			this.timeLiness_ = value;
		}
		
	}
	
}