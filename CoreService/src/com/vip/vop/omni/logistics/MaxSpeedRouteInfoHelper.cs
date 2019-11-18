using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.omni.logistics{
	
	
	
	public class MaxSpeedRouteInfoHelper : TBeanSerializer<MaxSpeedRouteInfo>
	{
		
		public static MaxSpeedRouteInfoHelper OBJ = new MaxSpeedRouteInfoHelper();
		
		public static MaxSpeedRouteInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(MaxSpeedRouteInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("sfOrderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSfOrderId(value);
					}
					
					
					
					
					
					if ("shopOrderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetShopOrderId(value);
					}
					
					
					
					
					
					if ("urlIndex".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUrlIndex(value);
					}
					
					
					
					
					
					if ("operatorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperatorName(value);
					}
					
					
					
					
					
					if ("operatorPhone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperatorPhone(value);
					}
					
					
					
					
					
					if ("riderLng".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRiderLng(value);
					}
					
					
					
					
					
					if ("riderLat".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRiderLat(value);
					}
					
					
					
					
					
					if ("orderStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrderStatus(value);
					}
					
					
					
					
					
					if ("statusDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStatusDesc(value);
					}
					
					
					
					
					
					if ("pushTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPushTime(value);
					}
					
					
					
					
					
					if ("sign".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSign(value);
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
		
		
		public void Write(MaxSpeedRouteInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSfOrderId() != null) {
				
				oprot.WriteFieldBegin("sfOrderId");
				oprot.WriteString(structs.GetSfOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShopOrderId() != null) {
				
				oprot.WriteFieldBegin("shopOrderId");
				oprot.WriteString(structs.GetShopOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUrlIndex() != null) {
				
				oprot.WriteFieldBegin("urlIndex");
				oprot.WriteString(structs.GetUrlIndex());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperatorName() != null) {
				
				oprot.WriteFieldBegin("operatorName");
				oprot.WriteString(structs.GetOperatorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperatorPhone() != null) {
				
				oprot.WriteFieldBegin("operatorPhone");
				oprot.WriteString(structs.GetOperatorPhone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRiderLng() != null) {
				
				oprot.WriteFieldBegin("riderLng");
				oprot.WriteString(structs.GetRiderLng());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRiderLat() != null) {
				
				oprot.WriteFieldBegin("riderLat");
				oprot.WriteString(structs.GetRiderLat());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderStatus() != null) {
				
				oprot.WriteFieldBegin("orderStatus");
				oprot.WriteI32((int)structs.GetOrderStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatusDesc() != null) {
				
				oprot.WriteFieldBegin("statusDesc");
				oprot.WriteString(structs.GetStatusDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPushTime() != null) {
				
				oprot.WriteFieldBegin("pushTime");
				oprot.WriteI32((int)structs.GetPushTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSign() != null) {
				
				oprot.WriteFieldBegin("sign");
				oprot.WriteString(structs.GetSign());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(MaxSpeedRouteInfo bean){
			
			
		}
		
	}
	
}