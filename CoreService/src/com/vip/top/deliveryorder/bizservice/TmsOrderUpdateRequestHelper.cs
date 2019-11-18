using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	public class TmsOrderUpdateRequestHelper : TBeanSerializer<TmsOrderUpdateRequest>
	{
		
		public static TmsOrderUpdateRequestHelper OBJ = new TmsOrderUpdateRequestHelper();
		
		public static TmsOrderUpdateRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TmsOrderUpdateRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("isJitX".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsJitX(value);
					}
					
					
					
					
					
					if ("deliveryWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliveryWarehouse(value);
					}
					
					
					
					
					
					if ("custCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustCode(value);
					}
					
					
					
					
					
					if ("transportNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportNo(value);
					}
					
					
					
					
					
					if ("carrierPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierPointCode(value);
					}
					
					
					
					
					
					if ("carrierPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierPointName(value);
					}
					
					
					
					
					
					if ("pickCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPickCode(value);
					}
					
					
					
					
					
					if ("srcSortingPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSrcSortingPointCode(value);
					}
					
					
					
					
					
					if ("srcSortingPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSrcSortingPointName(value);
					}
					
					
					
					
					
					if ("srcCarrierPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSrcCarrierPointCode(value);
					}
					
					
					
					
					
					if ("srcCarrierPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSrcCarrierPointName(value);
					}
					
					
					
					
					
					if ("destSortingPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDestSortingPointCode(value);
					}
					
					
					
					
					
					if ("destSortingPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDestSortingPointName(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(TmsOrderUpdateRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsJitX() != null) {
				
				oprot.WriteFieldBegin("isJitX");
				oprot.WriteI32((int)structs.GetIsJitX()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryWarehouse() != null) {
				
				oprot.WriteFieldBegin("deliveryWarehouse");
				oprot.WriteString(structs.GetDeliveryWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustCode() != null) {
				
				oprot.WriteFieldBegin("custCode");
				oprot.WriteString(structs.GetCustCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportNo() != null) {
				
				oprot.WriteFieldBegin("transportNo");
				oprot.WriteString(structs.GetTransportNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrierPointCode() != null) {
				
				oprot.WriteFieldBegin("carrierPointCode");
				oprot.WriteString(structs.GetCarrierPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrierPointName() != null) {
				
				oprot.WriteFieldBegin("carrierPointName");
				oprot.WriteString(structs.GetCarrierPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPickCode() != null) {
				
				oprot.WriteFieldBegin("pickCode");
				oprot.WriteString(structs.GetPickCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSrcSortingPointCode() != null) {
				
				oprot.WriteFieldBegin("srcSortingPointCode");
				oprot.WriteString(structs.GetSrcSortingPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSrcSortingPointName() != null) {
				
				oprot.WriteFieldBegin("srcSortingPointName");
				oprot.WriteString(structs.GetSrcSortingPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSrcCarrierPointCode() != null) {
				
				oprot.WriteFieldBegin("srcCarrierPointCode");
				oprot.WriteString(structs.GetSrcCarrierPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSrcCarrierPointName() != null) {
				
				oprot.WriteFieldBegin("srcCarrierPointName");
				oprot.WriteString(structs.GetSrcCarrierPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDestSortingPointCode() != null) {
				
				oprot.WriteFieldBegin("destSortingPointCode");
				oprot.WriteString(structs.GetDestSortingPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDestSortingPointName() != null) {
				
				oprot.WriteFieldBegin("destSortingPointName");
				oprot.WriteString(structs.GetDestSortingPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TmsOrderUpdateRequest bean){
			
			
		}
		
	}
	
}