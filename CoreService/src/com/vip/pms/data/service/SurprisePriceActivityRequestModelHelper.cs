using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class SurprisePriceActivityRequestModelHelper : TBeanSerializer<SurprisePriceActivityRequestModel>
	{
		
		public static SurprisePriceActivityRequestModelHelper OBJ = new SurprisePriceActivityRequestModelHelper();
		
		public static SurprisePriceActivityRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SurprisePriceActivityRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("activityNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActivityNo(value);
					}
					
					
					
					
					
					if ("name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetName(value);
					}
					
					
					
					
					
					if ("startTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetStartTime(value);
					}
					
					
					
					
					
					if ("endTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEndTime(value);
					}
					
					
					
					
					
					if ("longMessage".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLongMessage(value);
					}
					
					
					
					
					
					if ("shortMessage".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetShortMessage(value);
					}
					
					
					
					
					
					if ("iconLink".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIconLink(value);
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
		
		
		public void Write(SurprisePriceActivityRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetActivityNo() != null) {
				
				oprot.WriteFieldBegin("activityNo");
				oprot.WriteString(structs.GetActivityNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("activityNo can not be null!");
			}
			
			
			if(structs.GetName() != null) {
				
				oprot.WriteFieldBegin("name");
				oprot.WriteString(structs.GetName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("name can not be null!");
			}
			
			
			if(structs.GetStartTime() != null) {
				
				oprot.WriteFieldBegin("startTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetStartTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("startTime can not be null!");
			}
			
			
			if(structs.GetEndTime() != null) {
				
				oprot.WriteFieldBegin("endTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEndTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("endTime can not be null!");
			}
			
			
			if(structs.GetLongMessage() != null) {
				
				oprot.WriteFieldBegin("longMessage");
				oprot.WriteString(structs.GetLongMessage());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("longMessage can not be null!");
			}
			
			
			if(structs.GetShortMessage() != null) {
				
				oprot.WriteFieldBegin("shortMessage");
				oprot.WriteString(structs.GetShortMessage());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("shortMessage can not be null!");
			}
			
			
			if(structs.GetIconLink() != null) {
				
				oprot.WriteFieldBegin("iconLink");
				oprot.WriteString(structs.GetIconLink());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("iconLink can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SurprisePriceActivityRequestModel bean){
			
			
		}
		
	}
	
}