using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class UrlInfoHelper : TBeanSerializer<UrlInfo>
	{
		
		public static UrlInfoHelper OBJ = new UrlInfoHelper();
		
		public static UrlInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UrlInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("source".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSource(value);
					}
					
					
					
					
					
					if ("url".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUrl(value);
					}
					
					
					
					
					
					if ("longUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLongUrl(value);
					}
					
					
					
					
					
					if ("ulUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUlUrl(value);
					}
					
					
					
					
					
					if ("deeplinkUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeeplinkUrl(value);
					}
					
					
					
					
					
					if ("traFrom".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTraFrom(value);
					}
					
					
					
					
					
					if ("noEvokeUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNoEvokeUrl(value);
					}
					
					
					
					
					
					if ("noEvokeLongUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNoEvokeLongUrl(value);
					}
					
					
					
					
					
					if ("vipWxUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipWxUrl(value);
					}
					
					
					
					
					
					if ("vipWxCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipWxCode(value);
					}
					
					
					
					
					
					if ("vipQuickAppUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipQuickAppUrl(value);
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
		
		
		public void Write(UrlInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSource() != null) {
				
				oprot.WriteFieldBegin("source");
				oprot.WriteString(structs.GetSource());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUrl() != null) {
				
				oprot.WriteFieldBegin("url");
				oprot.WriteString(structs.GetUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLongUrl() != null) {
				
				oprot.WriteFieldBegin("longUrl");
				oprot.WriteString(structs.GetLongUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUlUrl() != null) {
				
				oprot.WriteFieldBegin("ulUrl");
				oprot.WriteString(structs.GetUlUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeeplinkUrl() != null) {
				
				oprot.WriteFieldBegin("deeplinkUrl");
				oprot.WriteString(structs.GetDeeplinkUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTraFrom() != null) {
				
				oprot.WriteFieldBegin("traFrom");
				oprot.WriteString(structs.GetTraFrom());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNoEvokeUrl() != null) {
				
				oprot.WriteFieldBegin("noEvokeUrl");
				oprot.WriteString(structs.GetNoEvokeUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNoEvokeLongUrl() != null) {
				
				oprot.WriteFieldBegin("noEvokeLongUrl");
				oprot.WriteString(structs.GetNoEvokeLongUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipWxUrl() != null) {
				
				oprot.WriteFieldBegin("vipWxUrl");
				oprot.WriteString(structs.GetVipWxUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipWxCode() != null) {
				
				oprot.WriteFieldBegin("vipWxCode");
				oprot.WriteString(structs.GetVipWxCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipQuickAppUrl() != null) {
				
				oprot.WriteFieldBegin("vipQuickAppUrl");
				oprot.WriteString(structs.GetVipQuickAppUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(UrlInfo bean){
			
			
		}
		
	}
	
}