using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.service{
	
	
	
	public class GetPackageTimeVoHelper : TBeanSerializer<GetPackageTimeVo>
	{
		
		public static GetPackageTimeVoHelper OBJ = new GetPackageTimeVoHelper();
		
		public static GetPackageTimeVoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetPackageTimeVo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("dateStr".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDateStr(value);
					}
					
					
					
					
					
					if ("hourOptionList".Equals(schemeField.Trim())){
						
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
						
						structs.SetHourOptionList(value);
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
		
		
		public void Write(GetPackageTimeVo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetDateStr() != null) {
				
				oprot.WriteFieldBegin("dateStr");
				oprot.WriteString(structs.GetDateStr());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("dateStr can not be null!");
			}
			
			
			if(structs.GetHourOptionList() != null) {
				
				oprot.WriteFieldBegin("hourOptionList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetHourOptionList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("hourOptionList can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetPackageTimeVo bean){
			
			
		}
		
	}
	
}