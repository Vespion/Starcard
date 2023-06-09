    function cb_replace(tag, timestamp, record)
      if (record["log"] == nil) 
      then
          return  0, 0, 0
          end

      local new_record = {}
      timeStr = os.date("!*t", timestamp["sec"])
      t = string.format("%4d-%02d-%02dT%02d:%02d:%02d.%sZ",
        timeStr["year"], timeStr["month"], timeStr["day"],
        timeStr["hour"], timeStr["min"], timeStr["sec"],
        timestamp["nsec"])
      kubernetes = {}
      kubernetes["pod_name"] = record["node_name"]
      kubernetes["container_name"] = "auditd"
      kubernetes["namespace_name"] = "kube-system"
      
      new_record["time"] = t
      new_record["log"] = record["log"]
      new_record["kubernetes"] = kubernetes
      return 1, timestamp, new_record
    end