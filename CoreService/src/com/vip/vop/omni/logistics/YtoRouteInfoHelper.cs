using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.omni.logistics{
	
	
	
	public class YtoRouteInfoHelper : TBeanSerializer<YtoRouteInfo>
	{
		
		public static YtoRouteInfoHelper OBJ = new YtoRouteInfoHelper();
		
		public static YtoRouteInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(YtoRouteInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("logisticProviderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLogisticProviderId(value);
					}
					
					
					
					
					
					if ("clientId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetClientId(value);
					}
					
					
					
					
					
					if ("mailNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMailNo(value);
					}
					
					
					
					
					
					if ("txLogisticId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTxLogisticId(value);
					}
					
					
					
					
					
					if ("infoType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInfoType(value);
					}
					
					
					
					
					
					if ("infoContent".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInfoContent(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("weight".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetWeight(value);
					}
					
					
					
					
					
					if ("signedName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSignedName(value);
					}
					
					
					
					
					
					if ("deliveryName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliveryName(value);
					}
					
					
					
					
					
					if ("acceptTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetAcceptTime(value);
					}
					
					
					
					
					
					if ("contactInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContactInfo(value);
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
		
		
		public void Write(YtoRouteInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetLogisticProviderId() != null) {
				
				oprot.WriteFieldBegin("logisticProviderId");
				oprot.WriteString(structs.GetLogisticProviderId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetClientId() != null) {
				
				oprot.WriteFieldBegin("clientId");
				oprot.WriteString(structs.GetClientId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMailNo() != null) {
				
				oprot.WriteFieldBegin("mailNo");
				oprot.WriteString(structs.GetMailNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTxLogisticId() != null) {
				
				oprot.WriteFieldBegin("txLogisticId");
				oprot.WriteString(structs.GetTxLogisticId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInfoType() != null) {
				
				oprot.WriteFieldBegin("infoType");
				oprot.WriteString(structs.GetInfoType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInfoContent() != null) {
				
				oprot.WriteFieldBegin("infoContent");
				oprot.WriteString(structs.GetInfoContent());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWeight() != null) {
				
				oprot.WriteFieldBegin("weight");
				oprot.WriteDouble((double)structs.GetWeight());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSignedName() != null) {
				
				oprot.WriteFieldBegin("signedName");
				oprot.WriteString(structs.GetSignedName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryName() != null) {
				
				oprot.WriteFieldBegin("deliveryName");
				oprot.WriteString(structs.GetDeliveryName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAcceptTime() != null) {
				
				oprot.WriteFieldBegin("acceptTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetAcceptTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContactInfo() != null) {
				
				oprot.WriteFieldBegin("contactInfo");
				oprot.WriteString(structs.GetContactInfo());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(YtoRouteInfo bean){
			
			
		}
		
	}
	
}