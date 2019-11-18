using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class BaseRequestHeaderHelper : TBeanSerializer<BaseRequestHeader>
	{
		
		public static BaseRequestHeaderHelper OBJ = new BaseRequestHeaderHelper();
		
		public static BaseRequestHeaderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BaseRequestHeader structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUserId(value);
					}
					
					
					
					
					
					if ("tokenId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTokenId(value);
					}
					
					
					
					
					
					if ("tokenSecret".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTokenSecret(value);
					}
					
					
					
					
					
					if ("ip".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIp(value);
					}
					
					
					
					
					
					if ("marsCid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMarsCid(value);
					}
					
					
					
					
					
					if ("needSaveAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetNeedSaveAmount(value);
					}
					
					
					
					
					
					if ("needFigureUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetNeedFigureUrl(value);
					}
					
					
					
					
					
					if ("needRebate".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetNeedRebate(value);
					}
					
					
					
					
					
					if ("needPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetNeedPrice(value);
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
		
		
		public void Write(BaseRequestHeader structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteI64((long)structs.GetUserId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userId can not be null!");
			}
			
			
			if(structs.GetTokenId() != null) {
				
				oprot.WriteFieldBegin("tokenId");
				oprot.WriteString(structs.GetTokenId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTokenSecret() != null) {
				
				oprot.WriteFieldBegin("tokenSecret");
				oprot.WriteString(structs.GetTokenSecret());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIp() != null) {
				
				oprot.WriteFieldBegin("ip");
				oprot.WriteString(structs.GetIp());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMarsCid() != null) {
				
				oprot.WriteFieldBegin("marsCid");
				oprot.WriteString(structs.GetMarsCid());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNeedSaveAmount() != null) {
				
				oprot.WriteFieldBegin("needSaveAmount");
				oprot.WriteBool((bool)structs.GetNeedSaveAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNeedFigureUrl() != null) {
				
				oprot.WriteFieldBegin("needFigureUrl");
				oprot.WriteBool((bool)structs.GetNeedFigureUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNeedRebate() != null) {
				
				oprot.WriteFieldBegin("needRebate");
				oprot.WriteBool((bool)structs.GetNeedRebate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNeedPrice() != null) {
				
				oprot.WriteFieldBegin("needPrice");
				oprot.WriteBool((bool)structs.GetNeedPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BaseRequestHeader bean){
			
			
		}
		
	}
	
}