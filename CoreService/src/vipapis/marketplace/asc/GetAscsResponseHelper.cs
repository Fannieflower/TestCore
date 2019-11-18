using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.asc{
	
	
	
	public class GetAscsResponseHelper : TBeanSerializer<GetAscsResponse>
	{
		
		public static GetAscsResponseHelper OBJ = new GetAscsResponseHelper();
		
		public static GetAscsResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetAscsResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("ascs".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.marketplace.asc.Asc> value;
						
						value = new List<vipapis.marketplace.asc.Asc>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.marketplace.asc.Asc elem1;
								
								elem1 = new vipapis.marketplace.asc.Asc();
								vipapis.marketplace.asc.AscHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAscs(value);
					}
					
					
					
					
					
					if ("has_next".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetHas_next(value);
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
		
		
		public void Write(GetAscsResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetAscs() != null) {
				
				oprot.WriteFieldBegin("ascs");
				
				oprot.WriteListBegin();
				foreach(vipapis.marketplace.asc.Asc _item0 in structs.GetAscs()){
					
					
					vipapis.marketplace.asc.AscHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHas_next() != null) {
				
				oprot.WriteFieldBegin("has_next");
				oprot.WriteBool((bool)structs.GetHas_next());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetAscsResponse bean){
			
			
		}
		
	}
	
}