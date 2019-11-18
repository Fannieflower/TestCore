using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	
	
	public class TmsOrderUpdateRequest {
		
		///<summary>
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		///</summary>
		
		private int? isJitX_;
		
		///<summary>
		///</summary>
		
		private string deliveryWarehouse_;
		
		///<summary>
		///</summary>
		
		private string custCode_;
		
		///<summary>
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		///</summary>
		
		private string carrierPointCode_;
		
		///<summary>
		///</summary>
		
		private string carrierPointName_;
		
		///<summary>
		///</summary>
		
		private string pickCode_;
		
		///<summary>
		///</summary>
		
		private string srcSortingPointCode_;
		
		///<summary>
		///</summary>
		
		private string srcSortingPointName_;
		
		///<summary>
		///</summary>
		
		private string srcCarrierPointCode_;
		
		///<summary>
		///</summary>
		
		private string srcCarrierPointName_;
		
		///<summary>
		///</summary>
		
		private string destSortingPointCode_;
		
		///<summary>
		///</summary>
		
		private string destSortingPointName_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public int? GetIsJitX(){
			return this.isJitX_;
		}
		
		public void SetIsJitX(int? value){
			this.isJitX_ = value;
		}
		public string GetDeliveryWarehouse(){
			return this.deliveryWarehouse_;
		}
		
		public void SetDeliveryWarehouse(string value){
			this.deliveryWarehouse_ = value;
		}
		public string GetCustCode(){
			return this.custCode_;
		}
		
		public void SetCustCode(string value){
			this.custCode_ = value;
		}
		public string GetTransportNo(){
			return this.transportNo_;
		}
		
		public void SetTransportNo(string value){
			this.transportNo_ = value;
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
		
	}
	
}