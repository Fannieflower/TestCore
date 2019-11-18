using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class PidGenRequestHelper : TBeanSerializer<PidGenRequest>
	{
		
		public static PidGenRequestHelper OBJ = new PidGenRequestHelper();
		
		public static PidGenRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PidGenRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("pidNameList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem0;
								elem0 = iprot.ReadString();
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPidNameList(value);
					}
					
					
					
					
					
					if ("requestId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRequestId(value);
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
		
		
		public void Write(PidGenRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPidNameList() != null) {
				
				oprot.WriteFieldBegin("pidNameList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetPidNameList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRequestId() != null) {
				
				oprot.WriteFieldBegin("requestId");
				oprot.WriteString(structs.GetRequestId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("requestId can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PidGenRequest bean){
			
			
		}
		
	}
	
}