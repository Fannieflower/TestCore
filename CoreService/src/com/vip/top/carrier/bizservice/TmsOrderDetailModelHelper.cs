using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class TmsOrderDetailModelHelper : TBeanSerializer<TmsOrderDetailModel>
	{
		
		public static TmsOrderDetailModelHelper OBJ = new TmsOrderDetailModelHelper();
		
		public static TmsOrderDetailModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TmsOrderDetailModel structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse(value);
					}
					
					
					
					
					
					if ("deliveryWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliveryWarehouse(value);
					}
					
					
					
					
					
					if ("receiverName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiverName(value);
					}
					
					
					
					
					
					if ("receiverPhone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiverPhone(value);
					}
					
					
					
					
					
					if ("receiverMobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiverMobile(value);
					}
					
					
					
					
					
					if ("receiverProvince".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiverProvince(value);
					}
					
					
					
					
					
					if ("receiverCity".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiverCity(value);
					}
					
					
					
					
					
					if ("receiverCounty".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiverCounty(value);
					}
					
					
					
					
					
					if ("receiverTown".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiverTown(value);
					}
					
					
					
					
					
					if ("receiverAddress".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiverAddress(value);
					}
					
					
					
					
					
					if ("receiverPostCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiverPostCode(value);
					}
					
					
					
					
					
					if ("isJitx".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsJitx(value);
					}
					
					
					
					
					
					if ("boxSeq".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBoxSeq(value);
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
		
		
		public void Write(TmsOrderDetailModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				oprot.WriteString(structs.GetWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryWarehouse() != null) {
				
				oprot.WriteFieldBegin("deliveryWarehouse");
				oprot.WriteString(structs.GetDeliveryWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiverName() != null) {
				
				oprot.WriteFieldBegin("receiverName");
				oprot.WriteString(structs.GetReceiverName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiverPhone() != null) {
				
				oprot.WriteFieldBegin("receiverPhone");
				oprot.WriteString(structs.GetReceiverPhone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiverMobile() != null) {
				
				oprot.WriteFieldBegin("receiverMobile");
				oprot.WriteString(structs.GetReceiverMobile());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiverProvince() != null) {
				
				oprot.WriteFieldBegin("receiverProvince");
				oprot.WriteString(structs.GetReceiverProvince());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiverCity() != null) {
				
				oprot.WriteFieldBegin("receiverCity");
				oprot.WriteString(structs.GetReceiverCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiverCounty() != null) {
				
				oprot.WriteFieldBegin("receiverCounty");
				oprot.WriteString(structs.GetReceiverCounty());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiverTown() != null) {
				
				oprot.WriteFieldBegin("receiverTown");
				oprot.WriteString(structs.GetReceiverTown());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiverAddress() != null) {
				
				oprot.WriteFieldBegin("receiverAddress");
				oprot.WriteString(structs.GetReceiverAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiverPostCode() != null) {
				
				oprot.WriteFieldBegin("receiverPostCode");
				oprot.WriteString(structs.GetReceiverPostCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsJitx() != null) {
				
				oprot.WriteFieldBegin("isJitx");
				oprot.WriteI32((int)structs.GetIsJitx()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBoxSeq() != null) {
				
				oprot.WriteFieldBegin("boxSeq");
				oprot.WriteString(structs.GetBoxSeq());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TmsOrderDetailModel bean){
			
			
		}
		
	}
	
}