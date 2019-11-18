using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.model.sync{
	
	
	
	public class ActObjectUpdateRequestHelper : TBeanSerializer<ActObjectUpdateRequest>
	{
		
		public static ActObjectUpdateRequestHelper OBJ = new ActObjectUpdateRequestHelper();
		
		public static ActObjectUpdateRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ActObjectUpdateRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("actNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActNo(value);
					}
					
					
					
					
					
					if ("delRangIdList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem1;
								elem1 = iprot.ReadString();
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDelRangIdList(value);
					}
					
					
					
					
					
					if ("addObjectMemberModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.model.sync.ActObjectMemberModel value;
						
						value = new com.vip.pms.data.model.sync.ActObjectMemberModel();
						com.vip.pms.data.model.sync.ActObjectMemberModelHelper.getInstance().Read(value, iprot);
						
						structs.SetAddObjectMemberModel(value);
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
		
		
		public void Write(ActObjectUpdateRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetActNo() != null) {
				
				oprot.WriteFieldBegin("actNo");
				oprot.WriteString(structs.GetActNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actNo can not be null!");
			}
			
			
			if(structs.GetDelRangIdList() != null) {
				
				oprot.WriteFieldBegin("delRangIdList");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetDelRangIdList()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddObjectMemberModel() != null) {
				
				oprot.WriteFieldBegin("addObjectMemberModel");
				
				com.vip.pms.data.model.sync.ActObjectMemberModelHelper.getInstance().Write(structs.GetAddObjectMemberModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ActObjectUpdateRequest bean){
			
			
		}
		
	}
	
}