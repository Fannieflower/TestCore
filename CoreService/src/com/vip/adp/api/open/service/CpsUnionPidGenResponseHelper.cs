using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class CpsUnionPidGenResponseHelper : TBeanSerializer<CpsUnionPidGenResponse>
	{
		
		public static CpsUnionPidGenResponseHelper OBJ = new CpsUnionPidGenResponseHelper();
		
		public static CpsUnionPidGenResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CpsUnionPidGenResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("pidInfoList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.adp.api.open.service.PidInfo> value;
						
						value = new List<com.vip.adp.api.open.service.PidInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.adp.api.open.service.PidInfo elem0;
								
								elem0 = new com.vip.adp.api.open.service.PidInfo();
								com.vip.adp.api.open.service.PidInfoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPidInfoList(value);
					}
					
					
					
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
					}
					
					
					
					
					
					if ("remainPidCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRemainPidCount(value);
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
		
		
		public void Write(CpsUnionPidGenResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPidInfoList() != null) {
				
				oprot.WriteFieldBegin("pidInfoList");
				
				oprot.WriteListBegin();
				foreach(com.vip.adp.api.open.service.PidInfo _item0 in structs.GetPidInfoList()){
					
					
					com.vip.adp.api.open.service.PidInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemainPidCount() != null) {
				
				oprot.WriteFieldBegin("remainPidCount");
				oprot.WriteI32((int)structs.GetRemainPidCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CpsUnionPidGenResponse bean){
			
			
		}
		
	}
	
}