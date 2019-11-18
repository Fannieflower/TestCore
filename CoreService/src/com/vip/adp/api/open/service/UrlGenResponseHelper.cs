using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class UrlGenResponseHelper : TBeanSerializer<UrlGenResponse>
	{
		
		public static UrlGenResponseHelper OBJ = new UrlGenResponseHelper();
		
		public static UrlGenResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UrlGenResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("urlInfoList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.adp.api.open.service.UrlInfo> value;
						
						value = new List<com.vip.adp.api.open.service.UrlInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.adp.api.open.service.UrlInfo elem0;
								
								elem0 = new com.vip.adp.api.open.service.UrlInfo();
								com.vip.adp.api.open.service.UrlInfoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetUrlInfoList(value);
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
		
		
		public void Write(UrlGenResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetUrlInfoList() != null) {
				
				oprot.WriteFieldBegin("urlInfoList");
				
				oprot.WriteListBegin();
				foreach(com.vip.adp.api.open.service.UrlInfo _item0 in structs.GetUrlInfoList()){
					
					
					com.vip.adp.api.open.service.UrlInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(UrlGenResponse bean){
			
			
		}
		
	}
	
}