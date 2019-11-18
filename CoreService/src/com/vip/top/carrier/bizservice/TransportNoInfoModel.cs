using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class TransportNoInfoModel {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		/// 三段码
		///</summary>
		
		private string pickCode_;
		
		///<summary>
		/// 发货地分拨中心编码
		///</summary>
		
		private string srcSortingPointCode_;
		
		///<summary>
		/// 发货地分拨中心名称
		///</summary>
		
		private string srcSortingPointName_;
		
		///<summary>
		/// 发货地站点编码
		///</summary>
		
		private string srcCarrierPointCode_;
		
		///<summary>
		/// 发货地站点名称
		///</summary>
		
		private string srcCarrierPointName_;
		
		///<summary>
		/// 目的地分拨中心编码
		///</summary>
		
		private string destSortingPointCode_;
		
		///<summary>
		/// 目的地分拨中心名称
		///</summary>
		
		private string destSortingPointName_;
		
		///<summary>
		/// 卸货点编码
		///</summary>
		
		private string unloadPointCode_;
		
		///<summary>
		/// 卸货点名称
		///</summary>
		
		private string unloadPointName_;
		
		///<summary>
		/// 始发地编码
		///</summary>
		
		private string originCode_;
		
		///<summary>
		/// 目的地编码
		///</summary>
		
		private string destinationCode_;
		
		///<summary>
		/// 站点编码
		///</summary>
		
		private string carrierPointCode_;
		
		///<summary>
		/// 站点名称
		///</summary>
		
		private string carrierPointName_;
		
		public string GetTransportNo(){
			return this.transportNo_;
		}
		
		public void SetTransportNo(string value){
			this.transportNo_ = value;
		}
		public string GetPickCode(){
			return this.pickCode_;
		}
		
		public void SetPickCode(string value){
			this.pickCode_ = value;
		}
		public string GetSrcSortingPointCode(){
			return this.srcSortingPointCode_;
		}
		
		public void SetSrcSortingPointCode(string value){
			this.srcSortingPointCode_ = value;
		}
		public string GetSrcSortingPointName(){
			return this.srcSortingPointName_;
		}
		
		public void SetSrcSortingPointName(string value){
			this.srcSortingPointName_ = value;
		}
		public string GetSrcCarrierPointCode(){
			return this.srcCarrierPointCode_;
		}
		
		public void SetSrcCarrierPointCode(string value){
			this.srcCarrierPointCode_ = value;
		}
		public string GetSrcCarrierPointName(){
			return this.srcCarrierPointName_;
		}
		
		public void SetSrcCarrierPointName(string value){
			this.srcCarrierPointName_ = value;
		}
		public string GetDestSortingPointCode(){
			return this.destSortingPointCode_;
		}
		
		public void SetDestSortingPointCode(string value){
			this.destSortingPointCode_ = value;
		}
		public string GetDestSortingPointName(){
			return this.destSortingPointName_;
		}
		
		public void SetDestSortingPointName(string value){
			this.destSortingPointName_ = value;
		}
		public string GetUnloadPointCode(){
			return this.unloadPointCode_;
		}
		
		public void SetUnloadPointCode(string value){
			this.unloadPointCode_ = value;
		}
		public string GetUnloadPointName(){
			return this.unloadPointName_;
		}
		
		public void SetUnloadPointName(string value){
			this.unloadPointName_ = value;
		}
		public string GetOriginCode(){
			return this.originCode_;
		}
		
		public void SetOriginCode(string value){
			this.originCode_ = value;
		}
		public string GetDestinationCode(){
			return this.destinationCode_;
		}
		
		public void SetDestinationCode(string value){
			this.destinationCode_ = value;
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
		
	}
	
}