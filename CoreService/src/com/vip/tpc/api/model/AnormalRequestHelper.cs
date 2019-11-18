using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class AnormalRequestHelper : TBeanSerializer<AnormalRequest>
	{
		
		public static AnormalRequestHelper OBJ = new AnormalRequestHelper();
		
		public static AnormalRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AnormalRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transportNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportNo(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCode(value);
					}
					
					
					
					
					
					if ("content".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContent(value);
					}
					
					
					
					
					
					if ("time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetTime(value);
					}
					
					
					
					
					
					if ("reportCity".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReportCity(value);
					}
					
					
					
					
					
					if ("reportOrgName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReportOrgName(value);
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
		
		
		public void Write(AnormalRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransportNo() != null) {
				
				oprot.WriteFieldBegin("transportNo");
				oprot.WriteString(structs.GetTransportNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transportNo can not be null!");
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCode() != null) {
				
				oprot.WriteFieldBegin("code");
				oprot.WriteString(structs.GetCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("code can not be null!");
			}
			
			
			if(structs.GetContent() != null) {
				
				oprot.WriteFieldBegin("content");
				oprot.WriteString(structs.GetContent());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("content can not be null!");
			}
			
			
			if(structs.GetTime() != null) {
				
				oprot.WriteFieldBegin("time");
				oprot.WriteI64((long)structs.GetTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("time can not be null!");
			}
			
			
			if(structs.GetReportCity() != null) {
				
				oprot.WriteFieldBegin("reportCity");
				oprot.WriteString(structs.GetReportCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReportOrgName() != null) {
				
				oprot.WriteFieldBegin("reportOrgName");
				oprot.WriteString(structs.GetReportOrgName());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AnormalRequest bean){
			
			
		}
		
	}
	
}